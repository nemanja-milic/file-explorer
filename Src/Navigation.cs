using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Src
{
    internal class Navigation
    {

        private List<string> OldPaths = new List<string>();

        private int IndexFolderPointer = -1;

        private bool CanGoBack => OldPaths.Count > 0;

        private bool CanGoForward => IndexFolderPointer < OldPaths.Count - 1;

        public Navigation()
        {
        }

        public void Add(string path)
        {
            if (IndexFolderPointer < OldPaths.Count -1)
            {
                OldPaths.RemoveRange(IndexFolderPointer + 1, Math.Abs((OldPaths.Count - 1) - IndexFolderPointer));
            }
            OldPaths.Add(path);
            IndexFolderPointer++;

        }

        public string GetBackFolderPath()
        {
            if(CanGoBack)
            {
                Console.WriteLine(OldPaths.Count);
                IndexFolderPointer--;
                return OldPaths[IndexFolderPointer];
            }
            else
            {
                throw new Exception("Cannot go back");
            }
        }

        public string GetForwardFolderPath()
        {
            if(!CanGoForward)
            {
                throw new Exception("Cannot go forward");
            }
            IndexFolderPointer++;
            return OldPaths[IndexFolderPointer];
        }

        // put an event every time indexfolder pointer chages check should button be available
    }
}
