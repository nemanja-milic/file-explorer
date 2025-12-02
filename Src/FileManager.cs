using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExplorer.Enums;
using FileExplorer.Models;

namespace FileExplorer.Src
{
    internal class FileManager
    {
        private ListView ListViewResources { get; }
        private TextBox CurrentPathTextBox { get; }

        private List<Folder> Folders = new List<Folder>();
        private string CurrentPath { get; set; } = "";

        private List<string> OldPaths = new List<string>();

        private int IndexFolderPointer = 0;

        public bool CanGoForward { get; set; } = false;

        //private List<File> Files;


        public FileManager(ListView listView, TextBox currentPathTextBox)
        {
            ListViewResources = listView;
            CurrentPathTextBox = currentPathTextBox;
        }


        public void FetchResources(string path) 
        {
            // fetch all files
           //  call render folder and files
            CurrentPath = path;
            
            FetchFolders(path);
           //Helper.PrintList(Folders);
        }

        private void FetchFolders(string path)
        {
            // add try and catch
            var folders = Directory.EnumerateDirectories(path);
            foreach (var folder in folders)
            {
                string cuttedFolderName = folder.Replace(path, "");
                DirectoryInfo directoryInfo = new DirectoryInfo(folder);
                Folders.Add(new Folder(cuttedFolderName, directoryInfo.LastWriteTime, folder)); 
            }
        }

        public void RenderFoldersAndFiles()
        {
            ImageController imageController = new ImageController();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(20, 20);
            imageList.Images.Add(imageController.ImageKeyFolder, Image.FromFile(imageController.Folder));
            ListViewResources.SmallImageList = imageList;

            CurrentPathTextBox.Text = CurrentPath;

            foreach(Folder folder in Folders)
            {
                ListViewItem listViewItem = new ListViewItem(folder.Name);
                listViewItem.SubItems.Add(folder.DateModified.ToString());
                listViewItem.SubItems.Add(folder.Type);
                listViewItem.SubItems.Add(folder.Size);
                listViewItem.Tag = new ListViewResourcesItem(folder.Path, ItemType.Folder);
                listViewItem.ImageKey = imageController.ImageKeyFolder;
                ListViewResources.Items.Add(listViewItem);
            }
        }

        public void ReloadView(string path)
        {
            ClearResources();
            FetchResources(path);
            RenderFoldersAndFiles();
        }

        // modify openFolder that accept nither path or listviewitem
        public void OpenFolder(ListView listView, ListViewItem folderOrFile)
        {
            // go thru MODELS, CASTING, ENUMS
            var castedTagObj = (ListViewResourcesItem)folderOrFile.Tag;

            

            // ask is castedTagObj diffrent from history[1] 
            // if it is then you list [root path, ]
            
            if(castedTagObj.ItemType == ItemType.Folder) 
            {
                // empty list view
                ReloadView(castedTagObj.Path);
            }
        }

        public void ClearResources()
        {
            // maybe in future add some spinner 
            ListViewResources.Items.Clear();
            Folders.Clear();
        }

        public void GoBackFromFolder()
        {
            if (CurrentPathTextBox.Text == @"C:\") return;
            string newPath = CurrentPath[..CurrentPath.LastIndexOf(Path.DirectorySeparatorChar)];

            // FIX: "C:" → "C:\" (or D:, E:, etc.)
            if (newPath == "C:") newPath = @"C:\";
            CurrentPathTextBox.Text = newPath;
            ReloadView(newPath);
            IndexFolderPointer--;
        }

        public void GoForward()
        {

        }
    }
}
