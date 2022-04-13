using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            decimal value = 1078.46m;

            //Formatar valor para pt-BR ou qualquer outra cultura
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU")));
            
            //Arredonda + ou -
            Console.WriteLine(Math.Round(value));
            
            //Arredonda para cima
            Console.WriteLine(Math.Ceiling(value));
            
            //Arredonda para baixo
            Console.WriteLine(Math.Floor(value));

        }
    }
}
