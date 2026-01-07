using FileExplorer.Src;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        private FileManager FileManager;
        public Form1()
        {
            InitializeComponent();
            FileManager = new FileManager(listViewResources, currentAddressTextBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileManager.Initialize(@"C:\");
        }

        private void listViewResources_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewItem clickedItem = listViewResources.GetItemAt(e.X, e.Y);
                if (clickedItem != null)
                {
                    FileManager.OpenFolder(listViewResources, clickedItem);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FileManager.GoBackFromFolder();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            FileManager.GoForward();
        }
    }
}
