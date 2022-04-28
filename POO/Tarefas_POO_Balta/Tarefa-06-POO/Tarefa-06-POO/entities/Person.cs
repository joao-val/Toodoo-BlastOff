using System;
using System.Text.RegularExpressions;

namespace Tarefa_06_POO.entities
{
    public class Person
    {

        public Person()
        {
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Telephone { get; set; }

        public double Height { get; set; }

        public void ShowPerson()
        {
            string height;
            var testNumberHeight = false;
            var testNameAddress = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the requested data of the person:");
                Console.WriteLine("Enter the name: ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter the address:");
                Address = Console.ReadLine();
                Console.WriteLine("Enter the telephone (only numbers):");
                Telephone = Console.ReadLine();
                Console.WriteLine("Enter the height in m(meters):");
                height = Console.ReadLine();

                testNumberHeight = int.TryParse(Telephone, out int x) && (Telephone.Length > 7 && Telephone.Length < 13)
                    && double.TryParse(height, out double y) 
                    && (double.Parse(height) >= 0.54 && double.Parse(height) <=2.72);

                testNameAddress = (Name.Contains(" ") && !Name.EndsWith(" ")) && !double.TryParse(Name, out y)
                    && !double.TryParse(Address, out y) && Address.Contains(" ")
                    && !Address.EndsWith(" ");

                if (testNumberHeight == false || testNameAddress == false) 
                {
                    Console.WriteLine();
                    Console.WriteLine("The name must be letters only, the address cannot be just numbers, and the phone/heigth must be only numbers!"); 
                    Console.WriteLine("Don't exaggerate the height, not too much or too little...");
                    Console.ReadKey();
                }
            } while (testNumberHeight == false || testNameAddress == false);

            Height = double.Parse(height);

            Console.Clear();
            Console.WriteLine("This person's data is:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Telephone: {Telephone}");
            Console.WriteLine($"Height: {Height}");
            Console.ReadKey();
        }
    }
}