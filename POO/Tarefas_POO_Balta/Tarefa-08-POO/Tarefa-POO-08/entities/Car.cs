using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarefa_POO_08.entities
{
    public class Car
    {

        public Car()
        {
        }


        public string CarPlate { get; set; }

        protected string Model { get; set; }

        protected string Color { get; set; }

        public static byte Fuel { get; set; }
        public static byte GASOLINE = 1;
        public static byte ETHANOL = 2;
        public static byte DIESEL = 3;
        public static byte GAS = 4;

        protected short Year { get; set; }

        protected double Cost { get; set; }

        public void FillCarPlate()
        {
            Regex lisencePlate = new Regex(@"^([A-Z]{3})[-]([\d]{4})$");
            Regex lisencePlateNew = new Regex(@"^([A-Z]{3}[\d])([A-Z][\d]{2})$");
            Console.Clear();
            Console.WriteLine("Enter the lisence plate of car in the Brazilian model (xxx0x00 or xxx-0000):");
            CarPlate = Console.ReadLine().ToUpper();
            if (!lisencePlateNew.IsMatch(CarPlate) && !lisencePlate.IsMatch(CarPlate))
            {
                Console.WriteLine(CarPlate);
                Console.WriteLine("Incorrect license plate format!");
                Console.ReadKey();
                FillCarPlate();
            }
        }

        public void FillCarInformation()
        {
            Regex color = new Regex(@"^[A-Za-zá-ú]{0,10}$");
            Regex model = new Regex(@"^([A-Za-zá-ú\d\-]{0,10})$");

            var teste = false;
            string year;
            do
            {
                Console.Clear();
                Console.WriteLine("___________________________________________________________________");
                Console.WriteLine("Fill in all the requested car information below.                  |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");         
                Console.WriteLine("Enter the model of car:");
                Model = Console.ReadLine();
                Console.WriteLine("Enter the color of car:");
                Color = Console.ReadLine();
                Console.WriteLine("Enter the year of car:");
                year = Console.ReadLine();

                teste = short.TryParse(year, out short x) && (short.Parse(year) <= DateTime.Now.Year && short.Parse(year) > 1960)
                    && color.IsMatch(Color) && model.IsMatch(Model);

                if (teste == false)
                {
                    Console.WriteLine("The information is in an incorrect format!");
                    Console.ReadKey();
                }
            } while (teste == false);
            Year = short.Parse(year);
        }

        public virtual double CarCost()
        {
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("________________________________________________________________________________");
                Console.WriteLine("|Enter the fuel of the car in question to know its price:                      |");
                Console.WriteLine("|Possible fuels are:                                                           |");
                Console.WriteLine("|GASOLINE R$12000,00 | ETHANOL R$10500,00 | DIESEL R$11000,00 | GAS R$13000,00 |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                option = Console.ReadLine().ToUpper();

                switch (option)
                {
                    case "GASOLINE":
                        Cost = 12000.00;
                        Fuel = GASOLINE;
                        break;

                    case "ETHANOL":
                        Cost = 10500.00;
                        Fuel = ETHANOL;
                        break;

                    case "DIESEL":
                        Cost = 11000.00;
                        Fuel = DIESEL;
                        break;

                    case "GAS":
                        Cost = 13000.00;
                        Fuel = GAS;
                        break;
                }
            } while (option != "GASOLINE" && option != "ETHANOL" && option != "DIESEL" && option != "GAS");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"The cost of this car is: R${Cost}");
            Console.ReadKey();
            return Cost;
        }

        public void CarInfo()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("All car information is!");
            Console.WriteLine($"The model is: {Model}");
            Console.WriteLine($"The color is: {Color}");
            Console.WriteLine($"The year is: {Year}");
            Console.WriteLine($"The car plate is: {CarPlate}");
            Console.WriteLine($"The cost of this car is: R${Cost}");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }

    }
}