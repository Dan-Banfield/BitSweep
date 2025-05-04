namespace BitSweep.Forms
{
    public partial class MainForm : Form
    {
        // A list to store the temporary file directories as selected by checkboxes.
        private List<string> selectedDirectories = new List<string>();

        private List<CheckBox> directoryCheckBoxes;

        public MainForm()
        {
            InitializeComponent();
            InitialiseCheckBoxList();
        }

        private void InitialiseCheckBoxList()
        {
            directoryCheckBoxes = new List<CheckBox>
            {
                temporaryFilesCheckBox,
                userTemporaryFilesCheckBox,
                windowsPrefetchFilesCheckBox,
                downloadedProgramFilesCheckBox,
                windowsUpdateCache,
                deliveryOptimisationFilesCheckBox,
                systemLogFilesCheckBox,
                minidumpsMemoryDumpsCheckBox
            };
        }

        private void sweepButton_Click(object sender, EventArgs e)
        {
            PopulateDirectoriesList();
            BeginSweep();
        }

        private void PopulateDirectoriesList()
        {
            foreach (CheckBox checkBox in directoryCheckBoxes)
            {
                if (checkBox.Checked && checkBox.Tag is string path)
                    selectedDirectories.Add(path);
            }
        }

        private void BeginSweep()
        {
            string list = "";
            foreach (string path in selectedDirectories)
                list += path + "\n";
            MessageBox.Show(list);
        }
    }
}