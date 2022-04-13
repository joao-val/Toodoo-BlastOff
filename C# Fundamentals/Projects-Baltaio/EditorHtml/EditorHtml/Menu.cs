using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml
{
    internal class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = Console.ReadLine();
            var test = Int32.TryParse(option, out int i);
            while (test == false)
            {
                Show();
            }
            HandleMenuOption(Int32.Parse(option));
        }

        private static void DrawScreen()
        {
            Contour();
            for(int lines = 0; lines <= 10; lines++)
            {
                Columns();
            }
            Contour();
            
        }

        private static void Contour()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        private static void Columns()
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write("\n");
        }

        private static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Select an option below ");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - New file");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Open");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Exit");
            Console.SetCursorPosition(3, 10);
            Console.Write("Option: ");

        }

        private static void HandleMenuOption(int option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Editor.Open(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}
