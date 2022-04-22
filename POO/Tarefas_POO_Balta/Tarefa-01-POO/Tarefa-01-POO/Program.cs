using System;
using Tarefa_01_POO.entities;

namespace Tarefa_01_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var rectangle = new Rectangle();
                var test = false;
                string length, width;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter the base size in 'm' (meters):");
                    length = Console.ReadLine();
                    Console.WriteLine("Enter the height size in 'm' (meters):");
                    width = Console.ReadLine();

                    test = (double.TryParse(length, out double x) && double.Parse(length) > 0)
                        && (double.TryParse(width, out x) && double.Parse(width) > 0);
                    
                    if (test == false)
                    {
                        Console.WriteLine("Please enter the values in the correct format!");
                        Console.ReadKey();
                    }
                    } while (test == false);

                rectangle.Length = double.Parse(length);
                rectangle.Width = double.Parse(width);

                Console.Clear();
                rectangle.PrintValueOfSides();
                Console.WriteLine("------------------------");

                Console.WriteLine("Do you want to change the value of the sides?");
                Console.WriteLine("Enter '-1' to yes or any other key to continue:");
                if (Console.ReadLine() == "-1")
                {
                    rectangle.ChangeValueOfSides();
                    Console.WriteLine("------------------------");
                    rectangle.PrintValueOfSides();
                }

                Console.Clear();
                Console.WriteLine($"{rectangle.CalculateArea()}m² of flooring and {rectangle.CalculatePerimeter()}m of baseboards will be needed to serve the place.");
                Console.WriteLine("-----------------------------------------------------------------------\n");
                Console.WriteLine("Type '-2' to exit or any other key to continue:");
            }while (Console.ReadLine() != "-2");
        }
    }
}
