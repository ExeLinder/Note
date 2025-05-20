using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    internal class Note
    {
        private void PrintFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"файл не знайдено: {path}");
                return;
            }
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine($"Вміст файлу \"{path}\":\n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
