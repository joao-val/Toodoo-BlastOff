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
            SavingsAccountList = new List<SavingsAccount>();
            CheckingAccountList = new List<CheckingAccount>();
        }

        public List<SavingsAccount> SavingsAccountList { get; set; }

        public List<CheckingAccount> CheckingAccountList { get; set; }

        public void Show()
        {
            var savingsAccount = new SavingsAccount();
            var checkingAccount = new CheckingAccount();
            string option;
            
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

                    if (SavingsAccountList.Count == 0)
                    {
                        savingsAccount.FillBalance();
                        savingsAccount.CalculatesYield();
                        SavingsAccountList.Add(savingsAccount);
                    }
                    else
                    {
                        for (int i = 0; i < SavingsAccountList.Count; i++)
                        {
                            if (SavingsAccountList[i].Number == savingsAccount.Number)
                            {
                                Console.Clear();
                                Console.WriteLine("This saving account number already exists!");
                                Console.ReadKey();
                                Show();
                            }
                        }
                        savingsAccount.FillBalance();
                        savingsAccount.CalculatesYield();
                        SavingsAccountList.Add(savingsAccount);
                    }
                    break;

                case "2":
                    checkingAccount.FillAccount();

                    if (CheckingAccountList.Count == 0)
                    {
                        checkingAccount.FillBalance();
                        checkingAccount.DiscountsMonthlyFee();
                        CheckingAccountList.Add(checkingAccount);
                    }
                    else
                    {
                        for (int i = 0; i < CheckingAccountList.Count; i++)
                        {
                            if (CheckingAccountList[i].Number == checkingAccount.Number)
                            {
                                Console.Clear();
                                Console.WriteLine("This checking account number already exists!");
                                Console.ReadKey();
                                Show();
                            }
                        }
                        checkingAccount.FillBalance();
                        checkingAccount.DiscountsMonthlyFee();
                        CheckingAccountList.Add(checkingAccount);
                    }
                    break;

                case "3":
                    Console.Clear();
                    if (SavingsAccountList.Count > 0)
                    {
                        Console.WriteLine("Existing savings accounts are:");
                        foreach (var account in SavingsAccountList)
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

                    if (CheckingAccountList.Count > 0)
                    {
                        Console.WriteLine("Existing checking accounts are:");
                        foreach (var account in CheckingAccountList)
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

                case "4": Environment.Exit(0); break;

                }
                if (option != "1" && option != "2" && option != "3" && option != "4")
                {
                    Console.WriteLine("Invalid Option!");
                    Console.ReadKey();
                }
                
            Show();
        }

    }
}
