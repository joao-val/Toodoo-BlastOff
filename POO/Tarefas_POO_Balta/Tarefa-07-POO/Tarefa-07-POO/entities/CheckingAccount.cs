using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_07_POO.entities
{
    public class CheckingAccount : Account
    {

        private double MonthlyPayment { get; set; }

        public void DiscountsMonthlyFee()
        {
            MonthlyPayment = 10.0;
            Console.Clear();
            Console.WriteLine($"Current account monthly fee is R${MonthlyPayment}!");
            
            FinalBalance = AccountBalance - MonthlyPayment;

            Console.WriteLine($"Your balance after the monthly fee is charged is R${Math.Round(FinalBalance, 2)}");
            Console.ReadKey();
        }

        public override void ShowAccount()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Your account is: Agency {Agency}| Number {Number}| Account opening balance R${Math.Round(AccountBalance, 2)}");
            Console.WriteLine($"The final balance of this account after the the monthly fee will be: R${Math.Round(FinalBalance, 2)}");
            Console.ReadKey();
        }
    }
}
