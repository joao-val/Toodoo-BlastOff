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

            Console.WriteLine("Type -1 to exit");

            var exit = Console.ReadLine();
            if (exit == "-1") Environment.Exit(0);

            Console.Clear();
            string name;
            Console.WriteLine("Enter your full name:");

            name = Console.ReadLine();
            var hello = new string[name.Length];
            int counter = 0;

            var position = name.IndexOf(" ");

            Console.Clear();
            Console.WriteLine(name.ToUpper());
            Console.WriteLine("------------------------");
            Console.WriteLine(name.ToLower());
            Console.WriteLine("------------------------");

            for (int i = 0; i < name.Length; i++)
            {
                hello[i] = name.Substring(i, 1);
                if (hello[i] != " ")
                {
                    counter++;
                }
            }

            Console.WriteLine("The total lenght of your name is: " + counter + " letters");
            Console.WriteLine("------------------------");
            Console.WriteLine("Your first name has " + name.Substring(0, position).Length + " letters");
            Console.WriteLine("------------------------");

            Console.ReadKey();
            show();
        }

    }
}
