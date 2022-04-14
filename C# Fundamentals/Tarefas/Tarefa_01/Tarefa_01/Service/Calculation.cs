using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_01
{
    internal class Calculation
    {

        public Calculation()
        {
        }

        public void show()
        {
            var teste1 = false;
            var teste2 = false;
            string v1;
            int v2;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter a number between 0 and 9999:");                
                v1 = Console.ReadLine();
                teste1 = (int.TryParse(v1, out int i)) && (int.Parse(v1) >= 0 && int.Parse(v1) <= 9999);
                teste2 = (v1.Length > 4) == false;

            }while((teste1 && teste2) == false);
            
            Console.WriteLine();
            v2 = int.Parse(v1);
            var result = v2.ToString().Length;

            switch (result)
            {
                case 1:
                    Console.WriteLine("Unidade: " + v1);
                    Console.WriteLine("Dezena: 0");
                    Console.WriteLine("Centena: 0");
                    Console.WriteLine("Unidade de milhar: 0");
                    break;

                case 2:
                    Console.WriteLine("Unidade: " + v1.Substring(1, 1));
                    Console.WriteLine("Dezena: " + v1.Substring(0, 1));
                    Console.WriteLine("Centena: 0");
                    Console.WriteLine("Unidade de milhar: 0");
                    break;

                case 3:
                    Console.WriteLine("Unidade: " + v1.Substring(2, 1));
                    Console.WriteLine("Dezena: " + v1.Substring(1, 1));
                    Console.WriteLine("Centena: " + v1.Substring(0, 1));
                    Console.WriteLine("Unidade de milhar: 0");
                    break;

                case 4:
                    Console.WriteLine("Unidade: " + v1.Substring(3, 1));
                    Console.WriteLine("Dezena: " + v1.Substring(2, 1));
                    Console.WriteLine("Centena: " + v1.Substring(1, 1)); ;
                    Console.WriteLine("Unidade de milhar: " + v1.Substring(0,1));
                    break;
            }
            Console.WriteLine();
        }
    }
}
