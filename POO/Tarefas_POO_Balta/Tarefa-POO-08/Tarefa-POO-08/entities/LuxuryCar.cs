using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_POO_08.entities
{
    public class LuxuryCar : Car
    {

        public LuxuryCar()
        {
        }


        public override double CarCost()
        {
            string option;
            var test = false;
            base.CarCost();
            do
            {
                Console.Clear();
                Console.WriteLine("___________________________________________________________________________________________________");
                Console.WriteLine("A luxury car comes with several perks such as air conditioning, power steering and eletric windows|");
                Console.WriteLine("In addition, it also comes with an on-board computer that parks the car by itself (for free)      |");
                Console.WriteLine("What options do you want to insert into the luxury car?                                           |");
                Console.WriteLine("Option 1: Air conditioning    = R$2000,00                                                         |");
                Console.WriteLine("Option 2: Hydraulic steering  = R$1500,00                                                         |");
                Console.WriteLine("Option 3: Eletric windows     = R$800,00                                                          |");
                Console.WriteLine("Option 4: All options above   = R$4300,00                                                         |");
                Console.WriteLine("Option 5: None of the options = R$0,00                                                            |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Cost += 2000.00; 
                        break;

                    case "2":
                        Cost += 1500.00;
                        break;

                    case "3":
                        Cost += 800.00;
                        break;

                    case "4":
                        Cost += 4300.00;
                        break;

                    case "5": break;
                }

                test = option == "1" || option == "2" || option == "3" || option == "4" || option == "5";
            } while (test == false);
            Console.WriteLine($"The price of this luxury car is: R${Cost}");
            return Cost;
        }

    }
}
