using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_10
{
    internal class Modifier
    {

        public Modifier()
        {
        }

        public void show()
        {

            Console.Clear();
            string name;
            var test = false;
            var test2 = false;
            Console.WriteLine("Enter your full name:");

            name = Console.ReadLine();
            test2 = name.EndsWith(" ");

            if (!name.Contains(" ") || test2 == true)
            {
                Console.WriteLine("Full name is required and cannot end with ' ' (empty space)!");
                Console.ReadKey();
                show();
            }

            var hello = new string[name.Length];
            int counter = 0;

            var position = name.IndexOf(" ");

            for (int i = 0; i < name.Length; i++)
            {
                hello[i] = name.Substring(i, 1);
                test = int.TryParse(hello[i], out int x);

                if (test == true)
                {
                    Console.WriteLine("Names do not contain numbers!");
                    Console.ReadKey();
                    show();
                }
                else if (hello[i] != " ") counter++;
            }

            Console.Clear();
            Console.WriteLine(name.ToUpper());
            Console.WriteLine("------------------------");
            Console.WriteLine(name.ToLower());
            Console.WriteLine("------------------------");

            Console.WriteLine("The total lenght of your name is: " + counter + " letters");
            Console.WriteLine("------------------------");
            Console.WriteLine("Your first name has " + name.Substring(0, position).Length + " letters");
            Console.WriteLine("------------------------");

            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Type -1 to exit");
            if (Console.ReadLine() == "-1") Environment.Exit(0);
            show();
        }
    }
}