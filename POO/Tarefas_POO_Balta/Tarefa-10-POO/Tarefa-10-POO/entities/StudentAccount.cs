using System;
using System.Runtime.InteropServices;
using Tarefa_10_POO.services;

namespace Tarefa_10_POO.entities
{
    public class StudentAccount : Buy
    {

        public StudentAccount()
        {
        }

        public override void PayInstallment()
        {
            Console.Clear();
            if (Installments == 0)
            {
                Console.WriteLine("Your monthly fees have already been paid off!");
                Console.ReadKey();
            }
            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine($"Still need to pay {Installments} installments!             ");
            Console.WriteLine($"Each installment has the value of R${Math.Round(Price, 2)}.");
            Console.WriteLine($"The total amount payable is R${Math.Round(Amount, 2)}.     ");
            Console.ReadKey();
            Installments--;
            Amount -= Price;
            Console.WriteLine($"You still need to pay {Installments} installments in the amount of R${Math.Round(Price, 2)}!");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }

        public override void PayAll()
        {
            string option;
            Console.Clear();
            if (Installments == 0)
            {
                Console.WriteLine("Your monthly fees have already been paid off!");
                Console.ReadKey();
            }
            Console.WriteLine("___________________________________________________________________________________________________");
            Console.WriteLine($"You still need to pay {Installments} installments in the amount of R${Math.Round(Price, 2)}!");
            Console.WriteLine($"The total amount payable is R${Math.Round(Amount, 2)}.");
            Console.WriteLine($"Do you really want to pay all installments of this purchase (type 'yes', any other key to 'no')?");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            
            option = Console.ReadLine().ToLower();
            if (option == "yes")
            {
                Installments = 0;
                Console.WriteLine($"You decided to zero your debts by paying an amount of R${Math.Round(Amount, 2)}!");
            }
            Console.WriteLine($"It remains to pay {Installments} installments!");
            Console.ReadKey();
        }

        public override void MakePurchase()
        {
            string price;
            var testPrice = false;
            
            do
            {
                Console.Clear();
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("What is the total cost (in R$) of this course? (Decimals are separated by ',')|");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                price = Console.ReadLine();
                testPrice = double.TryParse(price, out double x) && double.Parse(price) >= 1 && double.Parse(price) < 1000000;
                if (testPrice == false)
                {
                    Console.Clear();
                    Console.WriteLine("___________________________________________________");
                    Console.WriteLine("Please type in correct format!                    |");
                    Console.WriteLine("The value must be between R$1,00 and R$1000000,00 |");
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                    Console.ReadKey();
                }
            } while (testPrice == false);
            Amount = double.Parse(price);
        }

        public void Discount<T>(ref T x)
        {
            var buy = new Buy();
            var student = new StudentAccount();
            double installments;

            if (x.GetType() == buy.GetType())
            {
                Console.Clear();
                Console.WriteLine($"The total is: R${Math.Round(Amount, 2)}");
            }
            else if (x.GetType() == student.GetType())
            {
                Console.Clear();
                Amount = Amount / 2;
                installments = Installments/2;
                Installments = (int)Math.Ceiling(installments);
                Console.WriteLine($"The total amount received a discount of 50% R${Math.Round(Amount, 2)}.");
                Console.WriteLine($"And the number of installments too, now there are {Installments}!");
            }
            Console.ReadKey();
        }

    }
}