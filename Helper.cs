using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    internal class Helper
    {

        public static void PrintList<T>(List<T> list)
        {
            if (list == null)
            {
                Console.WriteLine("List is null.");
                return;
            }

            if (list.Count == 0)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
