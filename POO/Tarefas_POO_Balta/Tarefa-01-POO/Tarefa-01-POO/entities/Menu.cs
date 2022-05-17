using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_01_POO.entities
{
    internal class Menu
    {

        public Menu()
        {
        }

        public void Show()
        {
            
            var rectangle = new Rectangle();
            var test = false;
            string length, width, option;

            do
            {
                Console.Clear();
                Console.WriteLine("_________________________________________________________________________");
                Console.WriteLine("Chose an option below:                                                  |");
                Console.WriteLine("Option 1: Create a new rectangle!                                       |");
                Console.WriteLine("Option 2: Change the current rectangle!                                 |");
                Console.WriteLine("Option 3: Show the number of floors and baseboards needed for the site! |");
                Console.WriteLine("Option 4: To exit!                                                      |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
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

                        rectangle.CalculatePerimeter();
                        rectangle.CalculateArea();
                        rectangle.PrintValueOfSides();
                        Console.ReadKey();
                        break;

                    case "2":
                        if (rectangle.Perimeter == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("_______________________________________");
                            Console.WriteLine("You need to create a rectangle first! |");
                            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                            Console.ReadKey();
                            Show();
                        }
                        else
                        {
                            rectangle.ChangeValueOfSides();
                            rectangle.PrintValueOfSides();
                        }
                        break;

                    case "3":
                        if (rectangle.Perimeter == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("_______________________________________");
                            Console.WriteLine("You need to create a rectangle first! |");
                            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                            Console.ReadKey();
                            Show();
                        }
                        else
                        {
                            rectangle.ShowInfo();
                        }
                        break;
                }
            }while (option != "4");
            Environment.Exit(0);
        }

    }
}
