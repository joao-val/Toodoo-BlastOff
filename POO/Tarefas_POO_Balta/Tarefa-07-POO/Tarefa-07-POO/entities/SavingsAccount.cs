using System;

namespace Tarefa_07_POO.entities
{
    public class SavingsAccount : Account
    {
        private double IncomeSavings { get; set; }

        public void CalculatesYield()
        {
            IncomeSavings = 0.00895833;
            string mounth;
            var test = false;
            
            do
            {
                Console.Clear();
                Console.WriteLine("SAVINGS INCOME SIMULATOR!\n");
                Console.WriteLine($"How many months do you want to put balance R${Math.Round(AccountBalance, 2)} in savings?");
                Console.WriteLine("Maximum amount is 60 months...");
                mounth = Console.ReadLine();
                test = int.TryParse(mounth, out int x) && int.Parse(mounth) > 0 && int.Parse(mounth) < 60;
            } while (test == false);

            FinalBalance = AccountBalance + ((AccountBalance * IncomeSavings)* double.Parse(mounth));
            Console.Clear();
            Console.WriteLine($"Savings earn 10,75% per year!");
            Console.WriteLine($"Your savings at the end, with balance R${Math.Round(AccountBalance, 2)} for {mounth} months is: R${Math.Round(FinalBalance,2)}.");
            Console.ReadKey();
        }

        public override void ShowAccount()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Your account is: Agency {Agency}| Number {Number}| Account opening balance R${Math.Round(FinalBalance, 2)}");
            Console.WriteLine($"The final balance of this account after the savings simulation will be: R${Math.Round(FinalBalance, 2)}");
            Console.ReadKey();
        }
    }
}