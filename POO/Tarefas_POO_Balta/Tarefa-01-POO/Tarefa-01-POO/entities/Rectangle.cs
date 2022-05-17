using System;

namespace Tarefa_01_POO.entities
{
    public class Rectangle
    {

        public Rectangle()
        {
        }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Perimeter { get; set; }

        public double Area { get; set; }

        public void ChangeValueOfSides()
        {
            Console.Clear();
            var test = false;
            string newLength, newWidth;
            do
            {
                Console.WriteLine("Enter the new value for base:");
                newLength = Console.ReadLine();

                Console.WriteLine("Enter the new value for height:");
                newWidth = Console.ReadLine();

                test = (double.TryParse(newLength, out double x) && double.Parse(newLength) > 0)
                    && (double.TryParse(newWidth, out x) && double.Parse(newWidth) > 0);

                if (test == false)
                {
                    Console.WriteLine("Please enter the values in the correct format!");
                    Console.ReadKey();
                }
            }while (test == false);
            Length = double.Parse(newLength);
            Width = double.Parse(newWidth);
            CalculateArea();
            CalculatePerimeter();

            Console.ReadKey();
        }

        public void PrintValueOfSides()
        {
            Console.Clear();
            Console.WriteLine("___________________");
            Console.WriteLine($"Base = {Length}m |");
            Console.WriteLine($"Height = {Width}m|");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }

        public void CalculateArea()
        {
            Area = Length * Width;
        }

        public void CalculatePerimeter()
        {
            Perimeter = 2*(Length + Width);
        }

        public void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine($"{Area}m² of flooring and {Perimeter}m of baseboards will be needed to serve the place.");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.ReadKey();
        }

    }
}
