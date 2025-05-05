using BitSweep.Core;

namespace BitSweep.Forms
{
    public partial class CleaningForm : Form
    {
        private List<string> directoriesToBeSweeped;

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

            int files = await sweeper.CalculateFileCountAsync();
            progressBar.Maximum = files;

            await sweeper.SweepDirectoriesAsync();
        }

        private void Sweeper_FileSweeped(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Sweeper_FileSweeped(sender, e)));
                return;
            }

            progressBar.Value = Math.Min(progressBar.Value + 1, progressBar.Maximum);
            int percent = (int)((progressBar.Value - progressBar.Minimum) * 100.0 / (progressBar.Maximum - progressBar.Minimum));
            progressPercentageLabel.Text = $"{percent}%";
        }

        private void Sweeper_FileSweepFinished(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Sweeper_FileSweepFinished(sender, e)));
                return;
            }
            progressBar.Value = progressBar.Maximum;
            progressPercentageLabel.Text = "100%";

            MessageBox.Show("Files finished sweeping successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}