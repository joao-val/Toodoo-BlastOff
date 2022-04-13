using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new StringBuilder();
            text.Append("This text is a test\n");
            text.Append("This is a test\n");
            text.Append("This text \n");
            text.Append("This test is a wtf\n");

            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
