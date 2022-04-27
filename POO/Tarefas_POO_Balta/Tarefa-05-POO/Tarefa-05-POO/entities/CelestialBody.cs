using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tarefa_05_POO.entities
{
    public class CelestialBody
    {
        public CelestialBody()
        {
            
        }

        private string Name { get; set; }
        
        public string Type { get; set; }
        
        private double Mass { get; set; }
        
        private double Size { get; set; }

        public void CollectName()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Enter the name of the celestial body: ");
            var name = Console.ReadLine();
            Regex regex = new Regex(@"^([a-zA-Zà-úÀ-Ú])+$");
            if (regex.IsMatch(name))
            {
                Name = name;
            }
            else
            {
                Console.WriteLine("Please disregard the numbers and just put the name!");
                Console.ReadKey();
                CollectName();
            }
        }

        public void CollectType()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Enter the type of the celestial body (asteroid, planet or nebula): ");
            Console.WriteLine("If you enter a non-standard value, the 'asteroid' type will be assigned!");
            string type;
            do
            {
                type = Console.ReadLine().ToLower();
            } while (double.TryParse(type, out double x));

            if (type != "planet" && type != "nebula")
            {
                type = "asteroid";
            }
            Type = type;
        }

        public void CollectMass()
        {
            var test = false;
            string mass;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Enter the mass of the celestial body in Kg: ");
                mass = Console.ReadLine();
                test = double.TryParse(mass, out double x) 
                    && double.Parse(mass) > 0 && double.Parse(mass) <= 1000;
            }while(test == false);

            Mass = double.Parse(mass);
        }

        public void CollectSize()
        {
            var test = false;
            string size;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Enter the size of the celestial body in Km (if it's a nebula the measurement is light years):");
                size = Console.ReadLine();
                
                switch (Type)
                {
                    case "planet":
                        test = double.TryParse(size, out double y) && double.Parse(size) > 0
                            && double.Parse(size) <= 200000;
                        break;
                    default:
                        test = double.TryParse(size, out double x) && double.Parse(size) > 0 
                            && double.Parse(size) <= 1000;
                        break;
                }
                
            } while (test == false);

            Size = double.Parse(size);
        }

        public void ViewData()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");

            switch (Type)
            {
                case "asteroid":
                    Console.WriteLine($"Mass: {Mass} + (0,06 x 10^18)Kg");
                    Console.WriteLine($"Size: {Size}Km");
                    break;
                case "planet":
                    Console.WriteLine($"Mass: {Mass} x (10^24)Kg");
                    Console.WriteLine($"Size: {Size}Km");
                    break;
                case "nebula":
                    Console.WriteLine($"Mass: {Mass} ^35Kg");
                    Console.WriteLine($"Size: {Size} light-years");
                    break;
            }
        }
    }
}