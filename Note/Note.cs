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
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Enter operation");

                Console.WriteLine("1 - Print file");
                Console.WriteLine("2 - Write file");
                Console.WriteLine("3 - Show file");

                int operation = int.Parse(Console.ReadLine()!);

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Enter path");

                        string path1 = Console.ReadLine()!;

                        PrintFile(path1);

                        break;

                    case 2:
                        Console.WriteLine("Enter path");

                        string path2 = Console.ReadLine()!;

                        WriteFile(path2);

                        break;

                    case 3:
                        ShowFiles();

                        break;

                    default:

                        Console.WriteLine("wrong choice");

                        break;
                }
            }
        }

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
