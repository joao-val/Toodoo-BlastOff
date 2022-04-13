using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var myArray = new int[5] {1, 2, 3, 4, 5};
            myArray[0] = 12;

            var employees = new Employee[5];
            employees[0] = new Employee() { Id = 2579, Name = "André"};

            Console.WriteLine(myArray.Length);
            Console.WriteLine("----------------");

            //Percorrendo o array com for
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("----------------");

            //Percorrendo o array com foreach
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.Name);
            }

        }

        struct Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }
    }
}
