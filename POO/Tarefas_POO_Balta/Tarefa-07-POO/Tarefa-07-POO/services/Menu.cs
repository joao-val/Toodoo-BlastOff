using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_07_POO.entities;

namespace Tarefa_07_POO.services
{
    public class Menu
    {

        public Menu()
        {
        }

        public void Show()
        {
            var savingsAccount = new SavingsAccount();
            var checkingAccount = new CheckingAccount();

            var savingsAccountList = new List<SavingsAccount>();
            var checkingAccountList = new List<CheckingAccount>();

            string option;

            do
            {
                Console.Clear();
                Console.WriteLine("________________________________________");
                Console.WriteLine("|Choose an option below:               |");
                Console.WriteLine("|Option 1 to create a savings account! |");
                Console.WriteLine("|Option 2 to create a checking account!|");
                Console.WriteLine("|Option 3 to view existing accounts!   |");
                Console.WriteLine("|Option 4 to exit!                     |");
                Console.WriteLine("----------------------------------------");
                Console.Write("Enter the option: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        savingsAccount.FillAccount();

                        if (savingsAccountList.Count == 0)
                        {
                            savingsAccount.FillBalance();
                            savingsAccount.CalculatesYield();
                            savingsAccountList.Add(savingsAccount);
                        }
                        else
                        {
                            for (int i = 0; i < savingsAccountList.Count; i++)
                            {
                                if (savingsAccountList[i].Number == savingsAccount.Number)
                                {
                                    Console.Clear();
                                    Console.WriteLine("This savings account number already exists!");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    savingsAccount.FillBalance();
                                    savingsAccount.CalculatesYield();
                                    savingsAccountList.Add(savingsAccount);
                                }
                            }
                        }
                        break;

                    case "2":
                        checkingAccount.FillAccount();

                        if (checkingAccountList.Count == 0)
                        {
                            checkingAccount.FillBalance();
                            checkingAccount.DiscountsMonthlyFee();
                            checkingAccountList.Add(checkingAccount);
                        }
                        else
                        {
                            for (int i = 0; i < checkingAccountList.Count; i++)
                            {
                                if (checkingAccountList[i].Number == checkingAccount.Number)
                                {
                                    Console.Clear();
                                    Console.WriteLine("This checking account number already exists!");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    checkingAccount.FillBalance();
                                    checkingAccount.DiscountsMonthlyFee();
                                    checkingAccountList.Add(checkingAccount);
                                }
                            }
                        }
                        break;

                    case "3":
                        Console.Clear();
                        if (savingsAccountList.Count > 0)
                        {
                            Console.WriteLine("Existing savings accounts are:");
                            foreach (var account in savingsAccountList)
                            {
                                account.ShowAccount();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No savings accounts has been created!");
                        }
                        Console.ReadKey();
                        Console.WriteLine();

                        if (checkingAccountList.Count > 0)
                        {
                            Console.WriteLine("Existing checking accounts are:");
                            foreach (var account in checkingAccountList)
                            {
                                account.ShowAccount();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No checking accounts has been created!");
                            Console.ReadKey();
                        
                        }
                        break;
                }
                if (option != "1" && option != "2" && option != "3" && option != "4")
                {
                    Console.WriteLine("Invalid Option!");
                    Console.ReadKey();
                }
            }while(option != "4");

            
            
        }

    }
}
