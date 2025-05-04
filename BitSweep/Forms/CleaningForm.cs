namespace BitSweep.Forms
{
    public partial class CleaningForm : Form
    {
        public CleaningForm()
        {
            InitializeComponent();
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
    }
}