using BitSweep.Helpers;

namespace BitSweep.Forms
{
    public partial class MainForm : Form
    {
        // A list to store the temporary file directories for sweeping, as selected by checkboxes.
        private List<string> selectedDirectories = new List<string>();

        // Stores check boxes for easy iteration.
        private List<CheckBox> directoryCheckBoxes;

        public MainForm()
            => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
            => InitialiseCheckBoxList();

        private void sweepButton_Click(object sender, EventArgs e)
        {
            if (!PopulateDirectoriesList())
            {
                Utilities.ShowInformation("No temporary files are selected for sweeping.");
                return;
            }
            if (Utilities.AskQuestion("Proceed with sweeping temporary files?") == DialogResult.Yes) { BeginSweep(); }
        }

        private void InitialiseCheckBoxList()
            => directoryCheckBoxes = new List<CheckBox> { temporaryFilesCheckBox, userTemporaryFilesCheckBox, windowsPrefetchFilesCheckBox, downloadedProgramFilesCheckBox, windowsUpdateCache, deliveryOptimisationFilesCheckBox, systemLogFilesCheckBox, minidumpsMemoryDumpsCheckBox };

        private bool PopulateDirectoriesList()
        {
            bool checkBoxChecked = false;
            foreach (CheckBox checkBox in directoryCheckBoxes)
            {
                if (checkBox.Checked && checkBox.Tag is string path)
                {
                    selectedDirectories.Add(path);
                    checkBoxChecked = true;
                }
            }
            return checkBoxChecked;
        }

        private void BeginSweep()
        {
            new CleaningForm(selectedDirectories).Show();
            this.Hide();
        }
    }
}