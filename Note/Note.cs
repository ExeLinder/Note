using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    internal class Note
    {
        private void WriteFile(string path)
        {
            string choice = "";

            // Меню выбора режима записи
            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("Выберите режим записи:");
                Console.WriteLine("1 — Перезаписать файл");
                Console.WriteLine("2 — Дописать в конец");
                Console.WriteLine("3 — Посмотреть содержимое файла");

                choice = Console.ReadLine()!;

                if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Содержимое файла:\n");

                    try
                    {
                        if (File.Exists(path))
                        {
                            string[] lines = File.ReadAllLines(path);
                            foreach (string line in lines)
                                Console.WriteLine(line);
                        }
                        else
                        {
                            Console.WriteLine("Файл не существует.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
                    }

                    Console.WriteLine("\nНажмите Escape (Esc), чтобы вернуться...");
                    while (Console.ReadKey(true).Key != ConsoleKey.Escape)
                    {
                        // Ждём нажатие Esc
                    }

                    Console.Clear();
                    choice = "";
                }
                else if (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Неизвестный режим.\n");
                }
            }

            Console.WriteLine("\nВведите текст:");
            string text = Console.ReadLine()!;

            try
            {
                if (choice == "1")
                {
                    File.WriteAllText(path, text); // перезапись
                }
                else
                {
                    File.AppendAllText(path, text + Environment.NewLine); // дописать
                }

                Console.WriteLine("\nФайл успешно сохранён по пути: " + Path.GetFullPath(path));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

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
