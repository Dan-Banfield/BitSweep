namespace BitSweep.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            new CleaningForm().Show();
        }
    }
}