using System;
using System.Text.RegularExpressions;

namespace Tarefa_05_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regra = new Regex(@"^([0-9]{2})\.([0-9]{3})\.([0-9]{3})[-]([0-9])$");
            string rg;

            Console.WriteLine("Entre com o RG: ");
            rg = Console.ReadLine();

            Console.WriteLine("--------------------------------");
            if (regra.IsMatch(rg))
            {
                var match = regra.Match(rg);
                Console.WriteLine(match.Groups[1]);
                Console.WriteLine(match.Groups[2]);
                Console.WriteLine(match.Groups[3]);
                Console.WriteLine(match.Groups[4]);

                Console.WriteLine("RG válido");
            }
            else
            {
                Console.WriteLine("Não é valído esse RG");
            }

            Console.WriteLine("--------------------------------");
            Match mt = regra.Match(rg);
            if (mt.Success)
            {
                Console.WriteLine("RG Verdadeiro");
            }
            else
            {
                Console.WriteLine("RG falso");
            }

            Console.WriteLine("--------------------------------");
            String testeReplace = Regex.Replace(rg, @"\.", "#");
            Console.WriteLine(testeReplace);
        }
    }
}