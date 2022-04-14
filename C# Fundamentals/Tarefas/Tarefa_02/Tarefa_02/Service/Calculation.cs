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
            var teste1 = false;
            var teste2 = false;
            var result = 0;
            string v1;
            Random rand = new Random();

            do
            {
                Console.Clear();
                Console.WriteLine("Try to find the number randomly drawn between 0 and 5!");
                Console.WriteLine("Enter the number (0--5):");
                v1 = Console.ReadLine();
                teste1 = (int.TryParse(v1, out int i)) && (int.Parse(v1) <= 5 && int.Parse(v1) >= 0);
            }while (teste1 == false);

            result = rand.Next(0, 5);

            if (int.Parse(v1) == result)
            {
                Console.Clear();
                Console.WriteLine("Congratulations you got it right!");
                Console.WriteLine("The number drawn was " + result);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You didn't get it right, it happens!");
                Console.WriteLine("The number drawn was " + result);
            }
            Console.WriteLine();
        }
    }
}
