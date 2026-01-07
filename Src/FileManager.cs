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

        private List<Folder> Folders = new List<Folder>();

        private List<File> Files = new List<File>();

        private TextBox CurrentPathTextBox { get; set; }

        private Navigation Navigation;


        //private List<File> Files;


        public FileManager(ListView listView, TextBox currentPathTextBox)
        {
            ListViewResources = listView;
            CurrentPathTextBox = currentPathTextBox;
            Navigation = new Navigation();
        }

        public void Initialize(string defaultPath)
        {
            NavigateTo(defaultPath);
            Navigation.Add(defaultPath);
        }

        private void NavigateTo(string path)
        {
            ClearResources();
            FetchResources(path);
            CurrentPathTextBox.Text = path;
            RenderFoldersAndFiles();
        }

        public void OpenFolder(ListView listView, ListViewItem folder)
        {
            if (folder.Tag == null) throw new Exception("Folder does not have Tag property");
            var folderInfo = (ListViewResourcesItem)folder.Tag;
            NavigateTo(folderInfo.Path);
            Navigation.Add(folderInfo.Path);
        }

        private void FetchResources(string path) 
        {
            FetchFolders(path);
            FetchFiles(path);
        }

        public void GoBackFromFolder()
        {
            string path = Navigation.GetBackFolderPath();
            NavigateTo(path);
        }

        public void GoForward()
        {
            string path = Navigation.GetForwardFolderPath();
            NavigateTo(path);
        }

        private void FetchFolders(string path)
        {
            try
            {
                var folders = Directory.EnumerateDirectories(path);

                foreach (var folder in folders)
                {
                    string cuttedFolderName = folder.Replace(path, "");
                    DirectoryInfo directoryInfo = new DirectoryInfo(folder);
                    Folders.Add(new Folder(cuttedFolderName, directoryInfo.LastWriteTime, folder)); 
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }

        private void FetchFiles(string path)
        {
            try
            {
                var files = Directory.EnumerateFiles(path);

                foreach (var folder in files)
                {
                    string cuttedFileName = folder.Replace(path, "");
                    FileInfo fileInfo = new FileInfo(cuttedFileName);
                    Files.Add(new File(cuttedFileName, fileInfo.LastWriteTime, fileInfo.Name, fileInfo.Name ));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void RenderFoldersAndFiles()
        {
            ImageController imageController = new ImageController();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(20, 20);
            imageList.Images.Add(imageController.ImageKeyFolder, Image.FromFile(imageController.Folder));
            imageList.Images.Add(imageController.ImageKeyFile, Image.FromFile(imageController.File));
            ListViewResources.SmallImageList = imageList;

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

            foreach (File file in Files)
            {
                ListViewItem listViewItem = new ListViewItem(file.Name);
                listViewItem.SubItems.Add(file.DateModified.ToString());
                listViewItem.SubItems.Add(file.Type);
                listViewItem.SubItems.Add(file.Size);
                listViewItem.Tag = new ListViewResourcesItem(file.Path, ItemType.File);
                listViewItem.ImageKey = imageController.ImageKeyFile;
                ListViewResources.Items.Add(listViewItem);
            }
        }


        private void ClearResources()
        {
            // maybe in future add some spinner 
            ListViewResources.Items.Clear();
            Folders.Clear();
        }

    }
}
