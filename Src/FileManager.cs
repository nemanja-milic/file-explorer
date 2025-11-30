using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExplorer.Enums;

namespace FileExplorer.Src
{
    internal class FileManager
    {

        private List<Folder> Folders = new List<Folder>();
        //private List<File> Files;

        public void FetchResources(string path) 
        {
            // fetch all files
           //  call render folder and files

            FetchFolders(path);
            //Helper.PrintList(Folders);
        }

        private void FetchFolders(string path)
        {
            var folders = Directory.EnumerateDirectories(path);
            foreach (var folder in folders)
            {
                string cuttedFolderName = folder.Replace(path, "");
                DirectoryInfo directoryInfo = new DirectoryInfo(folder);
                Folders.Add(new Folder(cuttedFolderName, directoryInfo.LastWriteTime)); 
            }
        }

        public void RenderFoldersAndFiles(ListView listView)
        {
            ImageController imageController = new ImageController();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(20, 20);
            imageList.Images.Add(imageController.ImageKeyFolder, Image.FromFile(imageController.Folder));
            listView.SmallImageList = imageList;

            foreach(Folder folder in Folders)
            {
                ListViewItem listViewItem = new ListViewItem(folder.Name);
                listViewItem.SubItems.Add(folder.DateModified.ToString());
                listViewItem.SubItems.Add(folder.Type);
                listViewItem.SubItems.Add(folder.Size);
                listViewItem.Tag = ItemType.Folder; // I also need to store path to the file or folder
                listViewItem.ImageKey = imageController.ImageKeyFolder;
                listView.Items.Add(listViewItem);
            }
        }

        public void LeftClickOnItem(ListView listView, ListViewItem folderOrFile)
        {

            // here i would like to know did i click on folder or file 
            if((ItemType)folderOrFile.Tag == ItemType.Folder)
            {
                // empty list view
                OpenFolder(listView);
                FetchResources("C:\\Users\\Milic\\Desktop");
                RenderFoldersAndFiles(listView);
            }
        }

        public void OpenFolder(ListView listView)
        {
            // maybe in future add some spinner 
            listView.Items.Clear();
            Folders.Clear();
        }
    }
}
