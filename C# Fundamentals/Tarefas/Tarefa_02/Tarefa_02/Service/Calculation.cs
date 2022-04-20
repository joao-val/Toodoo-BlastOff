using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_02
{
    internal class Calculation
    {

        public Calculation()
        {
        }

        public void raffle()
        {
            var test = false;
            var result = 0;
            string number;
            Random rand = new Random();

            do
            {
                Console.Clear();
                Console.WriteLine("Try to find the number randomly drawn between 0 and 5 (Type -1 to exit)!");
                Console.WriteLine("Enter the number (0--5):");
                number = Console.ReadLine();

                if (number == "-1") Environment.Exit(0);
                test = (int.TryParse(number, out int i)) && (int.Parse(number) <= 5 && int.Parse(number) >= 0);
            }while (test == false);

            result = rand.Next(0, 5);

            if (int.Parse(number) == result)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Congratulations you got it right!");
                Console.WriteLine("The number drawn was " + result);
            }
            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("You didn't get it right, it happens!");
                Console.WriteLine("The number drawn was " + result);
            }
            Console.ReadKey();
            raffle();
        }
    }
}
