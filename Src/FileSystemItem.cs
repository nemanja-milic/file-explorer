using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Src
{
    internal abstract class FileSystemItem
    {
        public string Name { get; set; }
        public DateTime DateModified { get; set; }
        public string Path { get; set; }

        public abstract string  Type { get;  }
        public abstract string  Size { get; }

        protected FileSystemItem(string name, DateTime time, string path)
        {
            Name = name;
            DateModified = time;
            Path = path;
        }
    }
}
