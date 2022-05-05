using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_POO_08.entities;

namespace Tarefa_POO_08.service
{
    public class Menu
    {
        public Menu()
        {
            CarList = new List<Car>();
            LuxuryCarList = new List<LuxuryCar>();
        }

        public List<Car> CarList { get; set; }

        public List<LuxuryCar> LuxuryCarList { get; set; }

        public List<LuxuryCar> CarPlateList { get; set; }

        public void Show()
        {
            var car = new Car();
            var luxuryCar = new LuxuryCar();
            string option;

            Console.Clear();
            Console.WriteLine("|____________CAR REVIEW___________|");
            Console.WriteLine("|Choose an option below:          |");
            Console.WriteLine("|Option 1: Rate a popular car!    |");
            Console.WriteLine("|Option 2: Rate a luxury car!     |");
            Console.WriteLine("|Option 3: To view existing cars! |");
            Console.WriteLine("|Option 4: To exit!               |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    car.FillCarPlate();
                    if (CarList.Count == 0)
                    {
                        car.FillCarInformation();
                        car.CarCost();
                        car.CarInfo();
                        CarList.Add(car);
                    }
                    else
                    {
                        for (int i = 0; i < CarList.Count; i++)
                        {
                            if (CarList[i].CarPlate == car.CarPlate)
                            {
                                Console.Clear();
                                Console.WriteLine("This popular car already exists!");
                                Console.ReadKey();
                                Show();
                            }
                        }
                    car.FillCarInformation();
                    car.CarCost();
                    car.CarInfo();
                    CarList.Add(car);
                    }
                    break;

                case "2":
                    luxuryCar.FillCarPlate();
                    if (LuxuryCarList.Count == 0)
                    {
                        luxuryCar.FillCarInformation();
                        luxuryCar.CarCost();
                        luxuryCar.CarInfo();
                        LuxuryCarList.Add(luxuryCar);
                    }
                    else
                    {
                        for (int i = 0; i < LuxuryCarList.Count; i++)
                        {
                            if (LuxuryCarList[i].CarPlate == luxuryCar.CarPlate)
                            {
                                Console.Clear();
                                Console.WriteLine("This luxury car already exists!");
                                Console.ReadKey();
                                Show();
                            }
                        }
                        luxuryCar.FillCarInformation();
                        luxuryCar.CarCost();
                        luxuryCar.CarInfo();
                        LuxuryCarList.Add(luxuryCar);
                    }
                    break;

                case "3":
                    Console.Clear();
                    if (CarList.Count > 0)
                    {
                        Console.WriteLine("Existing popular cars are:");
                        foreach (Car cars in CarList)
                        {
                            cars.CarInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no popular car in the database!");
                        Console.ReadKey();
                    }

                    Console.WriteLine();
                    if (LuxuryCarList.Count > 0)
                    {
                        Console.WriteLine("Existing luxury cars are:");
                        foreach (LuxuryCar cars in LuxuryCarList)
                        {
                            cars.CarInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no luxury car in the database!");
                        Console.ReadKey();
                    }

                    break;

                case "4":
                    Environment.Exit(0);
                    break;
            }
            Show();
        }
    }
}
