using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingArrayValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrA = new int[4];
            var arrB = new int[4];

            arrA[0] = 23;

            arrB[0] = arrA[0];

            Console.WriteLine(arrB[0]);

            arrA.CopyTo(arrB, 0);

            Console.WriteLine(arrB[0]);
            Console.WriteLine(arrA[0]);

        }
    }
}
