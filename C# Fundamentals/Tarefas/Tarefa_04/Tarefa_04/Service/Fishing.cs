using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04
{
    internal class Fishing
    {

        public Fishing()
        {
        }

        public void weight()
        {
            var test1 = false;
            double excess, debit;
            string kilograms;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Enter how many kilograms of fish John caught (Decimals separated by ','):");
                Console.WriteLine("Each kilogram over 50 is subject to a fine of 4R$!");

                kilograms = Console.ReadLine();
                test1 = double.TryParse(kilograms, out double i) && double.Parse(kilograms) > 0;

            }while (test1 == false);

            if (double.Parse(kilograms) > 50)
            {
                Console.Clear();
                excess = double.Parse(kilograms) - 50;
                debit = excess * 4;
                Console.WriteLine("Jhon caught " + double.Parse(kilograms) + " kg");
                Console.WriteLine("Excess = " + Math.Round(excess, 3) + " Kg");
                Console.WriteLine("Debit = " + Math.Round(debit, 2) + " R$");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Jhon caught "+ double.Parse(kilograms) +" kg");
                Console.WriteLine("Excess = 0 Kg");
                Console.WriteLine("Debit = 0 R$");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("Type -1 to exit, any other key to continue:");
            if (Console.ReadLine() == "-1") Environment.Exit(0);
            weight();
        }

    }
}
