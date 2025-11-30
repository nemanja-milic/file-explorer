using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Src
{
    internal class Folder : FileSystemItem
    {
        public override string Size { get; } = "";

        public override string Type { get; } = "File Folder";

        public Folder(string name, DateTime time, string path)
            : base(name, time, path)
        {
        }
    }
}
