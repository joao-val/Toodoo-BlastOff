using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_08
{
    internal class CellPhone
    {

        public CellPhone()
        {
        }

        public void show()
        {
            var number = new string[10];
            var testOption = false;
            string option;

            do
            {
                Console.Clear();

                Console.WriteLine("Choose an option below.\n");
                Console.WriteLine("Option 1 to enter a phone number with a dash (-) in the middle:");
                Console.WriteLine("Option 2 to enter a phone number without a dash (-) in the middle:");
                Console.WriteLine("Option 0 to exit:\n");

                option = Console.ReadLine();
                testOption = int.TryParse(option, out int i) && (int.Parse(option) >= 0 && int.Parse(option) <=2); 

            }while(testOption == false);

            string numberFormat;
            var counter = 0;
            var test = false;
            var test2 = false;
            var x = 0;

            switch (int.Parse(option))
            {
                case 1:
                    Console.Clear();
                                    
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the number in the numberFormat (xxxx-xxxx)");
                        numberFormat = Console.ReadLine();

                        if (numberFormat.Length >= 8)
                        {
                            test = numberFormat.Substring(3, 1) == "-" || numberFormat.Substring(4, 1) == "-";
                            var position = numberFormat.IndexOf("-");
                            test2 = int.TryParse(numberFormat.Substring(0, 3), out int i) && int.TryParse(numberFormat.Substring(position, 4), out i);
                        }
                        
                    } while (numberFormat.Length < 8 || numberFormat.Length > 9 || test == false || test2 == false);

                    if (numberFormat.Length == 8)
                    {
                        number[0] = "3";
                        x = 1;
                    }

                    for (int i = x ; i < 9; i++)
                    {
                        number[i] = numberFormat.Substring(counter,1);
                        counter = counter +1;
                    }

                    Console.Clear();
                    Console.WriteLine("Phone number");
                    for (int i = 0; i <= 8; i++)
                    {
                        Console.Write(number[i]);
                    }

                    Console.ReadKey();
                    show();
                    break;

                case 2:
                    Console.Clear();

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the number in the numberFormat (xxxxxxxx)");
                        numberFormat = Console.ReadLine();

                        test = int.TryParse(numberFormat, out int i);

                    } while (numberFormat.Length < 7 || numberFormat.Length > 8 || test == false);

                    if (numberFormat.Length == 7)
                    {
                        number[0] = "3";
                        x = 1;
                    }

                    for (int i = x; i < 8; i++)
                    {
                        number[i] = numberFormat.Substring(counter, 1);
                        counter = counter + 1;
                    }

                    Console.Clear();
                    Console.WriteLine("Phone number");
                    for (int i = 0; i <= 7; i++)
                    {
                        Console.Write(number[i]);
                    }

                    Console.ReadKey();
                    show();
                    break;

                case 0: Environment.ExitCode = 0; break;
            }
            Console.Clear();
        }

    }
}
