using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarefa_07_POO.entities
{
    public abstract class Account
    {
        public Account()
        {
        }

        public Account(string number, string agency, double accountBalance)
        {
            Number = number;
            Agency = agency;
            AccountBalance = accountBalance;
        }
        public string Number { get; set; }

        protected string Agency { get; set; }

        protected double AccountBalance { get; set; }

        protected double FinalBalance { get; set; }

        public void FillAccount()
        {
            Regex regexNumber = new Regex(@"^([\d]{8})-([\d])$");
            Regex regexAgency = new Regex(@"^([\d]{4})-([\d])$");
            var test = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter your account details!\n");
                Console.WriteLine("Enter your account number (xxxxxxxx-x):");
                Number = Console.ReadLine();
                Console.WriteLine("Enter your agency number (xxxx-x):");
                Agency = Console.ReadLine();
                test = regexNumber.IsMatch(Number) && regexAgency.IsMatch(Agency);
                if (test == false)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Please put the information in the correct format!");
                    Console.ReadKey();
                }
            }while(test == false);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Your account is: Agency {Agency}| Number {Number}");
            Console.ReadKey();
        }

        public void FillBalance()
        {
            Regex regexAccountBalance = new Regex(@"^([\d]{1,6})[,]{0,1}([0-9]{0,2})$");
            var test = false;
            string accountBalance;
            do
            {
                Console.Clear();
                Console.WriteLine("\nEnter your account balance in R$ (decimals are separated by ','):");
                Console.WriteLine("It is mandatory to enter the cents, even if it is R$0,00");
                accountBalance = Console.ReadLine();
                test = regexAccountBalance.IsMatch(accountBalance);
                if (test == false)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Please put the information in the correct format!");
                    Console.WriteLine("If you wish to have a balance greater than R$999999,99 an assessment will be requested with a bank manager!");
                    Console.ReadKey();
                }
            } while (test == false);
            AccountBalance = double.Parse(accountBalance);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Opening balance R${Math.Round(AccountBalance, 2)}");
            Console.ReadKey();
        }

        public virtual void ShowAccount()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Your account is: Agency {Agency}| Number {Number}| Opening balance R${Math.Round(FinalBalance, 2)}");
            Console.ReadKey();
        }

    }
}