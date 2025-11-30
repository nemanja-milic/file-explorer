using FileExplorer.Src;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        FileManager FileManager = new FileManager();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // show c folder
            // C:\

            // a couple corrections
            // 1. Image class were based on is it  folder or file or type of file to return image path
            // 2. size property we should check is it something folder or file if file call file info if folder call folder info

            // step 1. make class file explorer view and paste the code that will output 
            // step 2. refactor the code, add class fileexplorer manager that will return list of all files and folder in form
            // { name: "something", lastUpdated: "21.09.2025", type: "Folder", size: "" }


            FileManager.FetchResources(@"C:\");
            FileManager.RenderFoldersAndFiles(listViewResources);

        }

        private void listViewResources_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewItem clickedItem = listViewResources.GetItemAt(e.X, e.Y);
                if (clickedItem != null) {
                    FileManager.LeftClickOnItem(listViewResources, clickedItem);
                }
            }
        }
    }
}
