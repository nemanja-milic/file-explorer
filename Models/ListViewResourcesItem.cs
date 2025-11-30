using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExplorer.Enums;

namespace FileExplorer.Models
{
    internal class ListViewResourcesItem
    {
        public ItemType ItemType { get; set; }
        public string Path { get; set; }

        public ListViewResourcesItem(string path, ItemType itemtype)
        {
            Path = path;
            ItemType = itemtype;
        }
    }
}
