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
                do
                {
                    Console.Clear();
                    Console.WriteLine("Choose one of the option below: ");
                    Console.WriteLine("Option 1: Change Fuel!");
                    Console.WriteLine("Option 2: Refuel by the value of the liter!");
                    Console.WriteLine("Option 3: Refuel by liter!");
                    Console.WriteLine("Option 4: Change the fuel liter value!");
                    option = Console.ReadLine();
                    test = int.TryParse(option, out int x) && int.Parse(option) >= 1 && int.Parse(option) < 5;
                } while (test == false);

                switch (int.Parse(option))
                {
                    case 1: fuelPump.ChangeFuel(); break;
                    case 2: fuelPump.RefuelByValue(); break;
                    case 3: fuelPump.RefuelByLiter(); break;
                    case 4: fuelPump.ChangeValue(); break;
                }

                Console.Clear();
                Console.WriteLine("Type -1 to exit or any other key to continue:");
                }while (Console.ReadLine() != "-1");

            Environment.Exit(0);
        }

        public FuelPump FuelPump { get; set; }
    }
}
