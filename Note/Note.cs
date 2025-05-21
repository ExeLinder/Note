using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    internal class Note
    {
        private void ShowFiles()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());

            Console.WriteLine("List of notes:");
            foreach (var file in files)
            {
                Console.WriteLine("- " + file);
            }
        }
    }
}
