using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculation
    {
        public Calculation()
        {

        }

        public void Sum()
        {
            Console.Clear();
            var teste1 = false;
            var teste2 = false;
            string v1, v2;

            do
            {
                Console.WriteLine("First value (Decimal places are separated by ','):");
                v1 = Console.ReadLine();

                Console.WriteLine("Second value (Decimal places are separated by ','):");
                v2 = Console.ReadLine();

                teste1 = (double.TryParse(v1, out double s));
                teste2 = (double.TryParse(v2, out double x));
                Console.Clear();
            } while ((teste1 && teste2) == false);

            var result = double.Parse(v1) + double.Parse(v2);


            Console.WriteLine();

            Console.WriteLine("The sum result is: " + (result));
            Console.WriteLine($"The sum result is: {result}");
            
            Console.ReadKey();
            Menu();
        }

        public void Subtraction()
        {
            Console.Clear();
            var teste1 = false;
            var teste2 = false;
            string v1, v2;

            do
            {
                Console.WriteLine("First value (Decimal places are separated by ','):");
                v1 = Console.ReadLine();

                Console.WriteLine("Second value (Decimal places are separated by ','):");
                v2 = Console.ReadLine();

                teste1 = (double.TryParse(v1, out double s));
                teste2 = (double.TryParse(v2, out double x));
                Console.Clear();
            } while ((teste1 && teste2) == false);

            var result = double.Parse(v1) - double.Parse(v2);

            Console.WriteLine();

            Console.WriteLine("The subtraction result is: " + (result));
            Console.WriteLine($"The subtraction result is: {result}");
            
            Console.ReadKey();
            Menu();
        }

        public void Division()
        {
            Console.Clear();
            var teste1 = false;
            var teste2 = false;
            string v1, v2;

            do
            {
                Console.WriteLine("First value (Decimal places are separated by ','):");
                v1 = Console.ReadLine();

                Console.WriteLine("Second value (Decimal places are separated by ','):");
                v2 = Console.ReadLine();

                teste1 = (double.TryParse(v1, out double s));
                teste2 = (double.TryParse(v2, out double x));
                Console.Clear();
            } while ((teste1 && teste2) == false);

            var result = double.Parse(v1) / double.Parse(v2);

            Console.WriteLine();
            Console.WriteLine("The division result is: " + (result).ToString("N3"));
            Console.WriteLine($"The division result is: {(result)}");

            Console.ReadKey();
            Menu();
        }

        public void Multiplication()
        {
            Console.Clear();
            var teste1 = false;
            var teste2 = false;
            string v1, v2;

            do
            {
                Console.WriteLine("First value (Decimal places are separated by ','):");
                v1 = Console.ReadLine();

                Console.WriteLine("Second value (Decimal places are separated by ','):");
                v2 = Console.ReadLine();

                teste1 = (double.TryParse(v1, out double s));
                teste2 = (double.TryParse(v2, out double x));
                Console.Clear();
            } while ((teste1 && teste2) == false);

            var result = double.Parse(v1) * double.Parse(v2);

            Console.WriteLine();
            Console.WriteLine("The division result is: " + (result).ToString("N3"));
            Console.WriteLine($"The division result is: {result}");
            
            Console.ReadKey();
            Menu();
        }

        public void Menu()
        {
            Console.Clear();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("----------");

            Console.WriteLine("Choose an option: ");

            var teste = false;

            do
            {
                var res = Console.ReadLine();
                teste = (Int32.TryParse(res, out int s));

                if (teste == true)
                {
                    switch (Int32.Parse(res))
                    {
                        case 1: Sum(); break;
                        case 2: Subtraction(); break;
                        case 3: Division(); break;
                        case 4: Multiplication(); break;
                        case 5: System.Environment.Exit(0); break;

                        default: Menu(); break;
                    }
                }
                Menu();
            } while (teste == false);
        }
    }
}
