using BitSweep.Core;

namespace BitSweep.Forms
{
    public partial class CleaningForm : Form
    {
        public CleaningForm(List<string> directoriesToClean)
        {
            InitializeComponent();
            InitialiseCleaningSequence(directoriesToClean);
        }

        private void CleaningForm_Load(object sender, EventArgs e)
            => LoadingTitleBehaviour();

        private void LoadingTitleBehaviour()
        {
            int delayMs = 500;

            Task.Run(async () => 
            {
                while (true) 
                {
                    await UpdateWindowTitleAsync("BitSweep — Cleaning"); await Task.Delay(delayMs);
                    await UpdateWindowTitleAsync("BitSweep — Cleaning."); await Task.Delay(delayMs);
                    await UpdateWindowTitleAsync("BitSweep — Cleaning.."); await Task.Delay(delayMs);
                    await UpdateWindowTitleAsync("BitSweep — Cleaning..."); await Task.Delay(delayMs);
                }
            });
        }

        private async Task UpdateWindowTitleAsync(string title)
        {
            if (InvokeRequired)
            {
                await Task.Run(() => Invoke((Action)(() => Text = title)));
                return;
            }
            Text = title;
        }

        private void InitialiseCleaningSequence(List<string> directories)
        {
            Sweeper sweeper = new Sweeper();

            sweeper.FileSweeped += Sweeper_FileSweeped;
            sweeper.FileSweepFinished += Sweeper_FileSweepFinished;

            int files = sweeper.CalculateFileCount(directories);
            progressBar.Maximum = files;

            sweeper.SweepDirectories(directories);
        }

        private void Sweeper_FileSweeped(object sender, EventArgs e)
        {
            //Marshall update back to UI thread to avoid issue.
            if (InvokeRequired)
            {
                Invoke(new Action(() => Sweeper_FileSweeped(sender, e)));
                return;
            }

            progressBar.Value = Math.Min(progressBar.Value + 1, progressBar.Maximum);
        }

        private async void Sweeper_FileSweepFinished(object sender, EventArgs e)
        {
            //Marshall update back to UI thread to avoid issue.
            if (InvokeRequired)
            {
                Invoke(new Action(() => Sweeper_FileSweepFinished(sender, e)));
                return;
            }

            progressBar.Value = progressBar.Maximum;
            await Task.Delay(2000);

            MessageBox.Show("Files finished sweeping successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}