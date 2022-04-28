using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_06_POO.entities
{
    public class Matrices
    {

        public Matrices()
        {
        }

        private double[,] Matrix = new double[3,4];


        public void FeedMatrix()
        {
            var rand = new Random();
            Console.Clear();
            Console.WriteLine("------------");
            for (int line = 0; line < 3; line++)
            {
                for(int column = 0; column < 4; column++)
                {
                    Matrix[line,column] = rand.Next(0, 50);
                    if (Matrix[line, column] < 10)
                    {
                        Console.Write("0" + Matrix[line, column] + "|");
                    }
                    else
                    {
                        Console.Write(Matrix[line, column] + "|");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void Sum()
        {
            double sum = 0;
            foreach (var matrix in Matrix)
            {
                sum += matrix;
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"The sum of all values in the array is: {sum}");
            Console.ReadKey();
        }

        public void LowerHigherValue()
        {
            double bigger = 0;
            double smaller = 50;
            foreach (var matrix in Matrix)
            {
                if (matrix > bigger)
                {
                    bigger = matrix;
                }
                else if (matrix < smaller)
                {
                    smaller = matrix;
                }
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"The bigger number in the matrix is {bigger}");
            Console.WriteLine($"The smallest number in the matrix is {smaller}");
            Console.ReadKey();
        }

        public void AverageMatrix()
        {
            double average = 0;
            int count = 0;
            foreach (var matrix in Matrix)
            {
                count++;
                average += matrix;
            }
            average= average/count;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"The average of the values in this matrix is {average}!");
        }

    }
}