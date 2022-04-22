using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_03_POO.entities
{
    public class TopBox : VIPTicket
    {

        public TopBox()
        {
        }

        public double AdditionalFee { get; set; }

        public double topBoxTicketPrice()
        {
            base.VIPTicketPrice();
            var test = false;
            string additionalCost;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Enter the additional value of the Top Box in R$:");
                additionalCost = Console.ReadLine();
                test = double.TryParse(additionalCost, out double x) && double.Parse(additionalCost) > 50
                    && double.Parse(additionalCost) < 2000.0;
                if (test == false)
                {
                    Console.WriteLine("Additional value cannot be greater than R$2000,00 or less than R$50,00!");
                    Console.ReadKey();
                }
            } while(test == false);

            Cost += double.Parse(additionalCost);
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"The value of Top Box is: R${Math.Round(Cost, 2)}");
            Console.ReadKey();
            return Math.Round (Cost, 2);
        }

    }
}
