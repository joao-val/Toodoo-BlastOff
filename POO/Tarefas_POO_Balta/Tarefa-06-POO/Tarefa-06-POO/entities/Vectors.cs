using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarefa_06_POO.entities
{
    public class Vectors
    {

        public Vectors()
        {
        }

        private float[] Vector = new float[5];

        public void FeedVector()
        {
            string preencher;
            var test = false;
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Enter the number for the position {i}:");
                    preencher = Console.ReadLine();
                    test = float.TryParse(preencher, out float x);
                    if (test == false)
                    { 
                        Console.WriteLine("Only numbers will be accepted!");
                        Console.ReadKey();
                    }
                }while (test == false);

                Vector[i] = float.Parse(preencher);
            }
        }

        public void ShowVectors()
        {
            int count = 0;
            Console.Clear();
            foreach (float f in Vector)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Position: {count}");
                Console.WriteLine(f);
                Console.ReadKey();
                count++;
            }
        }

        public void ShowIntegerVectors()
        {
            Regex regex = new Regex(@"^(-?[\d]+)$");
            string test;

            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("Only int positions!");
            for (int i = 0; i < 5; i++)
            {
                test = Vector[i].ToString();
                if (regex.IsMatch(test))
                {
                    Console.WriteLine("--------------");
                    Console.WriteLine($"Position: {i}");
                    Console.WriteLine(Vector[i]);
                    Console.ReadKey();
                }
            }
        }

        public void MultiplyByIntegers()
        {
            Regex regex = new Regex(@"^(-?[\d]+)$");
            var test = new string[5];
            var result = new float[5];
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Enter the int number for the multiplication * {Vector[i]}:");
                    test[i] = Console.ReadLine();
                    if (!regex.IsMatch(test[i]))
                    {
                        Console.WriteLine("Only int numbers will be accepted!");
                        Console.ReadKey();
                    }
                } while (!regex.IsMatch(test[i]));

                result[i] = Vector[i] * int.Parse(test[i]);
            }

            Console.Clear();
            Console.WriteLine("Multiplication results:");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"The result of multiplying {test[i]} and {Vector[i]} = {result[i]}");
            }
        }
    }
}
