using BitSweep.Core;
using BitSweep.Helpers;
using System.Diagnostics;

namespace BitSweep.Forms
{
    public partial class CleaningForm : Form
    {
        #region Local Variables

        private List<string> directoriesToBeSweeped;
        private long totalBytesFreed = 0;

        #endregion

        public CleaningForm(List<string> directoriesToClean)
        {
            InitializeComponent();
            directoriesToBeSweeped = directoriesToClean;
        }

        private void CleaningForm_Load(object sender, EventArgs e)
        {
            LoadingTitleBehaviour();
            InitialiseCleaningSequence();
        }

        private void LoadingTitleBehaviour()
        {
            int delayMs = 500;

            Task.Run(async () => 
            {
                while (true) 
                {
                    UpdateWindowTitleAsync("BitSweep — Cleaning"); await Task.Delay(delayMs);
                    UpdateWindowTitleAsync("BitSweep — Cleaning."); await Task.Delay(delayMs);
                    UpdateWindowTitleAsync("BitSweep — Cleaning.."); await Task.Delay(delayMs);
                    UpdateWindowTitleAsync("BitSweep — Cleaning..."); await Task.Delay(delayMs);
                }
            });
        }

        private void UpdateWindowTitleAsync(string title)
        {
            // Marshall update back to UI thread to avoid issue.
            if (InvokeRequired)
            {
                Invoke((Action)(() => Text = title));
                return;
            }
            Text = title;
        }

        private async void InitialiseCleaningSequence()
        {
            Sweeper sweeper = new Sweeper(directoriesToBeSweeped);

            sweeper.FileSweeped += Sweeper_FileSweeped;
            sweeper.FileSweepFinished += Sweeper_FileSweepFinished;

            progressBar.Maximum = await sweeper.CalculateFileCountAsync();

            await sweeper.SweepDirectoriesAsync();
        }

        private void Sweeper_FileSweeped(object sender, FileSweepedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Sweeper_FileSweeped(sender, e)));
                return;
            }
            totalBytesFreed += e.FileSize;
            UpdateDisplayValues(e.FileName);
        }

        private void Sweeper_FileSweepFinished(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Sweeper_FileSweepFinished(sender, e)));
                return;
            }

            FinaliseDisplayValues();
            ShowSweepResult();

            QueryRestart();
        }

        private void UpdateDisplayValues(string fileName)
        {
            progressBar.Value = Math.Min(progressBar.Value + 1, progressBar.Maximum);
            progressPercentageLabel.Text = $"{(int)((progressBar.Value - progressBar.Minimum) * 100.0 / (progressBar.Maximum - progressBar.Minimum))}%";
            deletingLabel.Text = $"Deleting: {fileName}";
        }

        private void FinaliseDisplayValues()
        {
            progressBar.Value = progressBar.Maximum;
            progressPercentageLabel.Text = "100%";
            deletingLabel.Text = "Done!";
        }

        private void ShowSweepResult()
            => Utilities.ShowInformation($"{Utilities.FormatBytes(totalBytesFreed)} of temporary files sweeped!");

        private void QueryRestart()
        {
            if (Utilities.AskQuestion("RECOMMENDED: restart your PC? This is recommended after cleaning temporary files.") == DialogResult.Yes)
            {
                RestartPC();
                return;
            }
            Application.Exit();
        }

        private void RestartPC()
        {
            Process.Start(new ProcessStartInfo 
            {
                FileName = "shutdown",
                Arguments = "/r /t 0",
                CreateNoWindow = true,
                UseShellExecute = false
            });
        }
    }
}