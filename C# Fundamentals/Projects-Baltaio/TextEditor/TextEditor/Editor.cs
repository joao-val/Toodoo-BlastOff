using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    internal class Editor
    {

        public Editor()
        {
        }

        public void Menu()
        {
            string option;
            var test1 = false;

            do
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1 - Open file");
                Console.WriteLine("2 - Create new file");
                Console.WriteLine("0 - Exit");
                Console.WriteLine();
                option = Console.ReadLine();
                test1 = int.TryParse(option, out int i);
                
            }while(test1 == false);

            switch (int.Parse(option))
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        private void Open()
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
                Console.Clear();
                Console.WriteLine("This file path does not exist");
            }

            Console.WriteLine();
            Console.ReadLine();
            Menu();

        }

        private void Edit()
        {
            Console.Clear();
            Console.WriteLine("Enter your text below: (ESC to exit)");
            Console.WriteLine("----------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        private void Save(String text)
        {
            Console.Clear();
            Console.WriteLine("What address to save the file?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"File {path} saved successfully!");
            Console.ReadLine();
            Menu();

        }
    }
}
