using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Src
{
    internal class File : FileSystemItem
    {

        public override string Type { get; }
        public override string Size {  get; }

        public File(string name, DateTime time, string path, string type)
            :base(name, time, path)
        {
            Type = type;
        }

    }
}
