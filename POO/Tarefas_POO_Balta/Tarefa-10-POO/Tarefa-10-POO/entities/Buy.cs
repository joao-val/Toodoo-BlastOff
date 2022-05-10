using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tarefa_10_POO.services;

namespace Tarefa_10_POO.entities
{
    public class Buy
    {

        public Buy()
        {
        }

        protected double Price { get; set; }

        protected int Installments { get; set; }

        protected string Type { get; set; }

        protected double DefaultInterest { get; set; }

        protected double Amount { get; set; }

        public virtual void MakePurchase()
        {
            string price, type;
            var testPrice = false;
            var testType = false;

            do
            {
                Console.Clear();
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("What is the value(in R$) of the purchase you want to make? (Decimals are separated by ',')|");
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
            }while (testPrice == false);
            Amount = double.Parse(price);

            do
            {
                Console.Clear();
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("Does your purchase fall into which of the types below? |");
                Console.WriteLine("Electronics | Automobiles | Clothes | Others           |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                type = Console.ReadLine().ToUpper();
                testType = type == "ELECTRONICS" || type == "AUTOMOBILES" || type == "CLOTHES" || type == "OTHERS";
            }while (testType == false);
            Type = type;
        }

        public void InstallmentsQuantity()
        {
            string quantity;
            var test = false;
            Console.Clear();
            Console.WriteLine("_________________________________________________________________________________________________________________________________");
            Console.WriteLine($"|How many times (between 1x and 10x) do you want to pay for this purchase (the purchase price is R${Amount})?                   ");
            Console.WriteLine($"|1x = interest free | 2x = 1,1% | 3x = 2,1% | 4x = 3,1% | 5x = 4,1% | 6x = 5,1% | 7x = 6,1% | 8x = 7,1% | 9x = 8,1% | 10x = 9,1%");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            quantity = Console.ReadLine();

            switch (quantity)
            {
                case "1":
                    Installments = 1;
                    Price = Math.Round(Amount, 2);
                    test = true;
                    break;

                case "2":
                    DefaultInterest = 0.011;
                    Installments = 2;
                    Price = (Amount + (Amount * DefaultInterest)) / 2;
                    test = true;
                    break;

                case "3":
                    DefaultInterest = 0.021;
                    Installments = 3;
                    Price = (Amount + (Amount * DefaultInterest)) / 3;
                    test = true;
                    break;

                case "4":
                    DefaultInterest = 0.031;
                    Installments = 4;
                    Price = (Amount + (Amount * DefaultInterest)) / 4;
                    test = true;
                    break;

                case "5":
                    DefaultInterest = 0.041;
                    Installments = 5;
                    Price = (Amount + (Amount * DefaultInterest)) / 5;
                    test = true;
                    break;

                case "6":
                    DefaultInterest = 0.051;
                    Installments = 6;
                    Price = (Amount + (Amount * DefaultInterest)) / 6;
                    test = true;
                    break;

                case "7":
                    DefaultInterest = 0.061;
                    Installments = 7;
                    Price = (Amount + (Amount * DefaultInterest)) / 7;
                    test = true;
                    break;

                case "8":
                    DefaultInterest = 0.071;
                    Installments = 8;
                    Price = (Amount + (Amount * DefaultInterest)) / 8;
                    test = true;
                    break;

                case "9":
                    DefaultInterest = 0.081;
                    Installments = 9;
                    Price = (Amount + (Amount * DefaultInterest)) / 9;
                    test = true;
                    break;

                case "10":
                    DefaultInterest = 0.091;
                    Installments = 10;
                    Price = (Amount + (Amount * DefaultInterest)) / 10;
                    test = true;
                    break;
            }
            if (test == false)
            {
                Console.Clear();
                Console.WriteLine("Invalid format, choose between 1 and 10 installments!");
                Console.ReadKey();
                InstallmentsQuantity();
            }
            else
            {
                Console.Clear();
                Amount = Installments * Price;
                Console.WriteLine($"You choose to pay in {Installments} installments!");
                Console.ReadKey();
            }
        }

        public virtual void PayInstallment()
        {
            Console.Clear();
            if(Installments == 0)
            {
                Console.WriteLine("Your purchase has already been paid!");
                Console.ReadKey();
            }
            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine($"You have {Installments} installments open!             ");
            Console.WriteLine($"Each installment has the value of R${Math.Round(Price, 2)}.");
            Console.WriteLine($"The total amount payable is R${Math.Round(Amount, 2)}.     ");
            Console.ReadKey();
            Installments--;
            Amount -= Price;
            Console.WriteLine($"You still need to pay {Installments} installments in the amount of R${Math.Round(Price, 2)}!");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }

        public virtual void PayAll()
        {
            string option;
            Console.Clear();
            if (Installments == 0)
            {
                Console.WriteLine("Your purchase has already been paid!");
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

        public void CancelPurchase()
        {
            string option;
            var menu = new Menu();
            Console.Clear();
            if (Installments == 0)
            {
                Console.WriteLine("Your purchase has already been paid!");
                Console.ReadKey();
                
            }
            Console.WriteLine("____________________________________________________________________________________________");
            Console.WriteLine($"You still need to pay {Installments} installments in the amount of R${Math.Round(Price, 2)}!");
            Console.WriteLine($"Do you really want to cancel this purchase (type 'yes' or 'no')?");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();

            option = Console.ReadLine().ToLower();
            if (option == "yes")
            {
                Installments = 0;
                Console.WriteLine("You have decided to cancel your purchase!");
            }
            else
            {
                Console.WriteLine("You have decided not to cancel your purchase!");
            }
            Console.WriteLine($"It remains to pay {Installments} installments!");
            Console.ReadKey();
        }

        public void UpdateInstallment()
        {
            double finalPrice;
            string installments, option;
            var testInstallments = false;
            Console.Clear();
            Console.WriteLine($"You still need to pay {Installments} installments in the amount of R${Math.Round(Price, 2)}!");
            Console.WriteLine("Do you want to renegotiate a new amount of installments (type 'yes' or any other key to 'no')?");
            option = Console.ReadLine().ToLower();
            if (option == "yes")
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("__________________________________________________________________________________________________________________________________");
                    Console.WriteLine("|Enter the new quantity os installments (between 1 and 10):                                                                      |");
                    Console.WriteLine("|1x = interest free | 2x = 1,1% | 3x = 2,1% | 4x = 3,1% | 5x = 4,1% | 6x = 5,1% | 7x = 6,1% | 8x = 7,1% | 9x = 8,1% | 10x = 9,1% |");
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                    installments = Console.ReadLine();
                    testInstallments = int.TryParse(installments, out int x) && int.Parse(installments) >= 1 && int.Parse(installments) <= 10;
                }while (testInstallments == false);

                switch (int.Parse(installments))
                {
                    case 1: PayAll(); break;
                    case 2: DefaultInterest = 0.011; break;
                    case 3: DefaultInterest = 0.021; break;
                    case 4: DefaultInterest = 0.031; break;
                    case 5: DefaultInterest = 0.041; break;
                    case 6: DefaultInterest = 0.051; break;
                    case 7: DefaultInterest = 0.061; break;
                    case 8: DefaultInterest = 0.071; break;
                    case 9: DefaultInterest = 0.081; break;
                    case 10: DefaultInterest = 0.091; break;
                }

                Installments = int.Parse(installments);
                finalPrice = Amount + (Amount * DefaultInterest) * Installments;
                Price = finalPrice / Installments;
                Amount = finalPrice;

                Console.Clear();
                Console.WriteLine($"Now you need to pay {Installments} installments in the amount of R${Math.Round(Price, 2)}!");
                Console.WriteLine($"The total amount payable is R${Math.Round(Amount, 2)}.");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You continue with the same payment terms!");
            }
            Console.ReadKey();
        }

    }
}