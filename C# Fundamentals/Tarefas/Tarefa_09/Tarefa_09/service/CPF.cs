using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_09
{
    internal class CPF
    {
        public CPF()
        {
        }

        public void show()
        {
            var testOption = false;
            string option;

            do
            {
                Console.Clear();

                Console.WriteLine("Choose an option below.\n");
                Console.WriteLine("Option 1 to test if a CPF is in the correct format:");
                Console.WriteLine("Option 2 to exit:\n");

                option = Console.ReadLine();
                testOption = int.TryParse(option, out int i) && (int.Parse(option) == 1 || int.Parse(option) == 2);

            } while (testOption == false);

            string numberFormat;
            var test = false;
            var test2 = false;
            var test3 = false;

            switch (int.Parse(option))
            {
                case 1:

                    Console.Clear();
                    Console.WriteLine("Enter the CPF in the format (xxx.xxx.xxx-xx)");
                    numberFormat = Console.ReadLine();


                    if (numberFormat.Length == 14)
                    {
                        test = numberFormat.Substring(3, 1) == "." && numberFormat.Substring(7, 1) == "." && numberFormat.Substring(11, 1) == "-";
                        test2 = int.TryParse(numberFormat.Substring(0, 3), out int i) && int.TryParse(numberFormat.Substring(4, 3), out i) &&
                                int.TryParse(numberFormat.Substring(8, 3), out i) && int.TryParse(numberFormat.Substring(11, 2), out i);
                    }

                    if (test == true && test2 == true)
                    {
                        Console.Clear();
                        Console.WriteLine("The CPF entered is valid, it is in the correct format!");
                        Console.WriteLine("CPF: " + numberFormat);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("The CPF entered is invalid, it is not in the correct format (xxx.xxx.xxx-xx)!");
                        Console.WriteLine("CPF: " + numberFormat);
                    }

                    Console.ReadKey();
                    show();
                    break;

                case 0: Environment.Exit(0); break;
            }

        }
    }
}
