using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_07
{
    public class Payroll
    {
        public Payroll()
        {
        }

        public void sellers()
        {
            var sales = new string[10];
            var total = new double[10];
            var baseSalary = 200;
            var position = new double[10];
            bool test;

            Console.Clear();
            Console.WriteLine("Enter the gross sales amount in $ of 10 sellers.");
            Console.WriteLine("The salesperson receives 9% of the gross value plus $200 base salary from his sales...\n");
            for (int i = 0; i < 10; i++)
            {
                test = false;
                
                Console.WriteLine("Enter the gross sales amount for seller " + (i + 1) + ":");
                sales[i] = Console.ReadLine();
                test = double.TryParse(sales[i], out double x);

                if(test == false)
                {
                    Console.WriteLine("Incorrect format!");
                    Console.ReadKey();
                    sellers();
                }

                total[i] = baseSalary + (double.Parse(sales[i]) * 0.09);
                
                if (total[i] > 1000)  position[8] += 1;
            }
            Console.Clear();

            var range1 = Enumerable.Range(200, 799);
            int[] Range = Enumerable.ToArray(range1);

            for (int i = 0; i < 10; i++)
            {
                foreach (var r in Range)
                {
                    var result = r;
                    if (Math.Ceiling(total[i]) == result)
                    {
                        result = (r - 200) / 100;
                        position[result] += 1;
                    }
                    
                }
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(position[i]+ " sellers between" + " $" + baseSalary + " - $" + (baseSalary + 99));
                baseSalary = baseSalary + 100;
            }
            Console.WriteLine(position[8] + " $" + baseSalary + " onward");

            Console.ReadKey();
        }

    }
}
