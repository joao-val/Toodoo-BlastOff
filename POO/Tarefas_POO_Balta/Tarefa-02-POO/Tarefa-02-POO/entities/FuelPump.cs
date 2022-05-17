using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_02_POO.entities.enums;

namespace Tarefa_02_POO.entities
{
    public class FuelPump
    {

        public FuelPump()
        {
        }

        public double FuelQuantity { get; set; }
        public double LiterValue { get; set; }
        public EFuelType FuelType { get; set; }

        public void RefuelByValue()
        {
            var test = false;
            string pay;
            do
            {
                Console.Clear();
                Console.WriteLine("______________________________________________________");
                Console.WriteLine($"The value of a liter of {FuelType} is R${LiterValue}!");
                Console.WriteLine($"Enter how many R$ of {FuelType} you want to refill:");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                pay = Console.ReadLine();
                test = double.TryParse(pay, out double x) && double.Parse(pay) > 0;
            } while (test == false);

            var liter = double.Parse(pay) / LiterValue;
            if (liter > FuelQuantity)
            {
                Console.WriteLine($"Insufficient amount of fuel, you ordered {Math.Round(liter, 2)}L and the tank contains {FuelQuantity}L");
                Console.ReadKey();
                RefuelByValue();
            }
            else
            {
                Console.WriteLine($"You put {Math.Round(liter, 2)}L of {FuelType} in the car!");
                Console.ReadKey();
                ChangeFuelQuantity(liter);
            }
        }

        public void RefuelByLiter()
        {
            var test = false;
            string liter;
            do
            {
                Console.Clear();
                Console.WriteLine("________________________________________________________");
                Console.WriteLine($"The value of a liter of {FuelType} is R${LiterValue}!");
                Console.WriteLine($"Enter how many liters of {FuelType} you want to refill:");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                liter = Console.ReadLine();
                test = double.TryParse(liter, out double x) && double.Parse(liter) > 0 && double.Parse(liter) < FuelQuantity;
            } while (test == false);

            var pay = double.Parse(liter) * LiterValue;
            if (double.Parse(liter) > FuelQuantity)
            {
                Console.WriteLine($"Insufficient amount of fuel, you ordered {Math.Round(double.Parse(liter), 2)}L and the tank contains {FuelQuantity}L");
                Console.ReadKey();
                RefuelByValue();
            }
            else
            {
                Console.WriteLine($"The amount payable by the customer is: R${Math.Round(pay, 2)}");
                Console.ReadKey();
                ChangeFuelQuantity(double.Parse(liter));
            }
        }

        public void ChangeValue()
        {
            var test = false;
            string money;
            do
            {
                Console.Clear();
                Console.WriteLine($"The value of {FuelType} is R${LiterValue}!");
                Console.WriteLine($"Enter a new value for {FuelType}:");
                money = Console.ReadLine();
                test = double.TryParse(money, out double x) && double.Parse(money) >= 2.5;
            }while (test == false);

            Console.Clear();
            LiterValue = double.Parse(money);
            Console.WriteLine($"The new value of {FuelType} is R${Math.Round(LiterValue, 2)}!");
            Console.ReadKey();
        }

        public void ChangeFuel()
        {
            var test = false;
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("__________________________________________");
                Console.WriteLine("Enter the type of fuel you wish to fill: |");
                Console.WriteLine("Ethanol = 1 | Gasoline = 2 | Diesel = 3  |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                option = Console.ReadLine();
                test = int.TryParse(option, out int x) && (int.Parse(option) > 0 && int.Parse(option) <= 3);
            } while (test == false);

            switch (int.Parse(option))
            {
                case 1:
                    double ethanol = 20000.0;
                    if (int.Parse(option) == (int)FuelType) ethanol = FuelQuantity;

                    FuelQuantity = ethanol;
                    FuelType = (EFuelType)1;
                    LiterValue = 5.565;
                    break;

                case 2:
                    double gasoline = 20000.0;
                    if (int.Parse(option) == (int)FuelType) gasoline = FuelQuantity;

                    FuelQuantity = gasoline;
                    FuelType = (EFuelType)2;
                    LiterValue = 7.601;
                    break;

                case 3:
                    double diesel = 20000.0;
                    if (int.Parse(option) == (int)FuelType) diesel = FuelQuantity;

                    FuelQuantity = diesel;
                    FuelType = (EFuelType)3;
                    LiterValue = 6.854;
                    break;

            }
            Console.Clear();
            Console.WriteLine($"You chose {FuelType}, the price of a liter is R${LiterValue}");
            Console.WriteLine($"The {FuelType} tank still contains {Math.Round(FuelQuantity, 2)}L (liters)!");
            Console.ReadKey();
        }

        public double ChangeFuelQuantity(double drain)
        {
            Console.Clear();
            FuelQuantity -= drain;
            Console.WriteLine($"The fuel pump still has {Math.Round(FuelQuantity, 2)}L of {FuelType}!");
            Console.ReadKey();
            return FuelQuantity;
        }
    }
}
