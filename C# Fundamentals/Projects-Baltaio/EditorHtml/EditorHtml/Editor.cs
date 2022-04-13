using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml
{
    internal class Editor
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Editor Mode(type 'Esc' to exit)");
            Console.WriteLine("-------------------------------");
            Start();
        }
        
        private static void Start()
        {
            var file = new StringBuilder();
            
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------");
            Console.WriteLine("Do you want to save the file? (Yes/No)");
            var save = Console.ReadLine();

            while (save.ToLower() != "yes" && save.ToLower() != "no")
            {
                Console.Clear();
                Console.WriteLine("\nType Yes or No! \n");
                save = Console.ReadLine();
            }
            if (save == "yes")
            {
                Saving();
            }
            else
            {
                Viewer.Show(file.ToString());
            }
        }

        private static void Saving()
        {
            string text = null;
            Console.Clear();
            Console.WriteLine("What is the path to save the file?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.WriteLine(text);
            }

            Console.WriteLine($"File saved successfully in path {path}.");
            Console.ReadKey();
        }

        public static void Open()
        {
            Console.Clear();
            Console.WriteLine("What is the file path?");
            string path = Console.ReadLine();

            try
            {
                using (var file = new StreamReader(path))
                {
                    string text = file.ReadToEnd();
                    Console.WriteLine(text);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This file path does not exist");
            }
            Console.WriteLine();
            Console.ReadLine();
            Menu.Show();

        }

    }
}
