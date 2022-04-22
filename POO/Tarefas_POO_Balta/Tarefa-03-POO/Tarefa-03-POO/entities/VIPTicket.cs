using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_03_POO.entities.father;

namespace Tarefa_03_POO.entities
{
    public class VIPTicket : Ticket
    {
        public VIPTicket()
        {
        }

        public double AdditionalCost { get; set; }

        public virtual double VIPTicketPrice()
        {
            var test = false;
            string additionalCost;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the additional value of the VIP ticket in R$:");
                additionalCost = Console.ReadLine();
                test = double.TryParse(additionalCost, out double x) && double.Parse(additionalCost) > 50
                    && double.Parse(additionalCost) < 2000.0;
                if (test == false)
                {
                    Console.WriteLine("Additional value cannot be greater than R$2000,00 or less than R$50,00!");
                    Console.ReadKey();
                }
            }while (test == false);

            Console.Clear();
            AdditionalCost = double.Parse(additionalCost);
            Cost += AdditionalCost;
            Console.WriteLine($"VIP ticket price is: R${Math.Round(Cost,2)}!");
            Console.ReadKey();
            return Cost;
        }

    }
}
