using System;

namespace Tarefa_01_POO.entities
{
    public class Rectangle
    {

        public Rectangle()
        {
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void ChangeValueOfSides()
        {
            Console.Clear();
            var test = false;
            Console.WriteLine("Enter the new value for base:");
            var newLength = Console.ReadLine();
            
            Console.WriteLine("Enter the new value for height:");
            var newWidth = Console.ReadLine();

            test = (double.TryParse(newLength, out double x) && double.Parse(newLength) > 0)
                && (double.TryParse(newWidth, out  x) && double.Parse(newWidth) > 0);

            if (test == false)
            {
                Console.WriteLine("Please enter the values in the correct format!");
                Console.ReadKey();
                ChangeValueOfSides();
            }

            Length = double.Parse(newLength);
            Width = double.Parse(newWidth);
        }

        public void PrintValueOfSides()
        {
            Console.WriteLine($" Base = {Length}m | Height = {Width}m");
        }

        public double CalculateArea()
        {
            var area = Length * Width;
            return area;
        }

        public double CalculatePerimeter()
        {
            var perimeter = 2*(Length + Width);
            return perimeter;
        }

        public double Width { get; set; }

        public double Length { get; set; }

    }
}
