using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "Testing";
            Console.WriteLine(text);

            string res = Console.ReadLine();
            var teste = false;

            teste = (double.TryParse(res, out double s));

            Console.WriteLine(teste);
            Console.ReadKey();
            
        }
    }
}
