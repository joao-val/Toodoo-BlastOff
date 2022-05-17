using System;

namespace Tarefa_02_POO.entities
{
    public class Menu
    {
        public Menu()
        {
        }

        public void show()
        {
            FuelPump fuelPump = new FuelPump();
            string option;
            var test = false;

            fuelPump.ChangeFuel();
            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("_____________________________________________");
                Console.WriteLine("Choose one of the option below:             |");
                Console.WriteLine("Option 1: Change Fuel!                      |");
                Console.WriteLine("Option 2: Refuel by the value of the liter! |");
                Console.WriteLine("Option 3: Refuel by liter!                  |");
                Console.WriteLine("Option 4: Change the fuel liter value!      |");
                Console.WriteLine("Option 5: To exit!                          |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                option = Console.ReadLine();
                
                switch (option)
                {
                    case "1": fuelPump.ChangeFuel(); break;
                    case "2": fuelPump.RefuelByValue(); break;
                    case "3": fuelPump.RefuelByLiter(); break;
                    case "4": fuelPump.ChangeValue(); break;
                }
            }while (option != "5");

            Environment.Exit(0);
        }
    }
}
