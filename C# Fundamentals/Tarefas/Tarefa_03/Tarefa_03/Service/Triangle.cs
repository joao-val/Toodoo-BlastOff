using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_03
{
    internal class Triangle
    {

        public Triangle()
        {
        }

        public void triangleTest()
        {
            var test1 = false;
            var test2 = false;
            var test3 = false;
            var testNumber = false;
            string A, B, C;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter the value in cm of 3 lines (A, B, C) to check if they can form a triangle.");
                Console.WriteLine("|B - C| < A < B+C \n|A - C| < B < A+C \n|A - B| < C < A+B\n");

                Console.WriteLine("First line A:");
                A = Console.ReadLine();

                Console.WriteLine("Second line B:");
                B = Console.ReadLine();

                Console.WriteLine("Third line C:");
                C = Console.ReadLine();

                testNumber = (double.TryParse(A, out double i) && double.TryParse(B, out i) && double.TryParse(C, out i));
            } while (testNumber == false);

            var a = double.Parse(A);
            var b = double.Parse(B);
            var c = double.Parse(C);

            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("A triangle cannot have a negative line.");
                Console.ReadKey();
                triangleTest();
            }

            test1 = (b - c) < a && a < (b + c);
            test2 = (a - c) < b && b < (a + c);
            test3 = (a - b) < c && c < (a + b);
            
            if ((test1 && test2 && test3) == true)
            {
                Console.Clear();
                Console.WriteLine("These 3 lines can form a triangle!!");
                Console.WriteLine(A + "cm|" + B + "cm|" + C + "cm");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error, these 3 lines cannot form a triangle!!");
                Console.WriteLine(A + "cm|" + B + "cm|" + C + "cm");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("Type -1 to exit, any other key to continue:");
            if (Console.ReadLine() == "-1") Environment.Exit(0);
            triangleTest();
        }

    }
}
