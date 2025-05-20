using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    internal class Note
    {
        private void PrintFile(string path) { }
        private void WriteFile(string path) { }
        private void ShowFiles() { }
        public void Menu() { }
        private void ShowFiles(string folderPath)
        {
            folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Notes");

            Console.WriteLine("Your folder: " + folderPath + "\n");

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Notes folder not found. Creating...");
                Directory.CreateDirectory(folderPath);
                return;
            }

            string[] files = Directory.GetFiles(folderPath);

            if (files.Length == 0)
            {
                Console.WriteLine("There are no notes.");
                return;
            }

            Console.WriteLine("List of notes:");
            foreach (var file in files)
            {
                Console.WriteLine("- " + Path.GetFileName(file));
            }
        }

    }
}
