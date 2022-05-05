using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarefa_09_POO.entities
{
    public class PremiumVisitor : Visitor
    {

        public PremiumVisitor()
        {
        }

        public double Balance { get; set; } = 100.00;

        public string MealTicketNumber { get; set; }

        public void FillInMealTicket()
        {
            Regex testNumber = new Regex(@"^([\d]{12})$");
            string number;
            Console.Clear();
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Let's fill your card!                                             |");
            Console.WriteLine("Enter the meal voucher number in the correct format (12 numbers): |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            number = Console.ReadLine();
            if (!testNumber.IsMatch(number))
            {
                Console.WriteLine("Incorrect format!");
                Console.ReadKey();
                FillInMealTicket();
            }
            MealTicketNumber = number;

            Console.Clear();
            Console.WriteLine("_______________________________________________");
            Console.WriteLine($"Your meal voucher number is: {MealTicketNumber}");
            Console.WriteLine($"The remaining balance is: R${Balance}          ");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }

        public void Spent()
        {
            string spent;
            Regex testSpent = new Regex(@"^[\d]{1,3}$");
            var test = false;
            Console.Clear();
            Console.WriteLine($"Current balance R${Math.Round(Balance, 2)}");
            Console.WriteLine("Enter how much you want to spend from the voucher:");
            spent = Console.ReadLine();
            test = testSpent.IsMatch(spent) && double.Parse(spent) <= Balance;

            if (test == false)
            {
                Console.WriteLine("Insufficient balance to carry out the transaction!");
                Console.WriteLine($"Current balance R${Math.Round(Balance, 2)}");
                Console.ReadKey();
                Spent();
            }
            
            Balance = Balance - double.Parse(spent);
            Console.Clear();
            Console.WriteLine($"Current balance R${Math.Round(Balance, 2)}");
            Console.ReadKey();
        }
    }
}
