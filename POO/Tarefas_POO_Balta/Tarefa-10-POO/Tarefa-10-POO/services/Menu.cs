using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_10_POO.entities;

namespace Tarefa_10_POO.services
{
    public class Menu
    {

        public Menu()
        {
            BuyList = new List<Buy>();
            StudentAccountList = new List<StudentAccount>();
        }

        public List<Buy> BuyList { get; set; }

        public List<StudentAccount> StudentAccountList { get; set; }

        public void Show()
        {
            var buy = new Buy();
            var studentAccount = new StudentAccount();
            string option;

            Console.Clear();
            Console.WriteLine("|______________________________________________|");
            Console.WriteLine("|Choose an option below:                       |");
            Console.WriteLine("|Option 1: Make a purchase!                    |");
            Console.WriteLine("|Option 2: Make a student account!             |");
            Console.WriteLine("|Option 3: To exit!                            |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    buy.MakePurchase();
                    buy.InstallmentsQuantity();
                    BuyList.Add(buy);
                    PurchaseMenu();
                    Console.ReadKey();
                    break;

                case "2":
                    studentAccount.MakePurchase();
                    studentAccount.InstallmentsQuantity();
                    StudentAccountList.Add(studentAccount);
                    StudentMenu();
                    Console.ReadKey();
                    break;

                case "3":
                    Environment.Exit(0);
                    break;
            }
            Show();
        }

        public void PurchaseMenu()
        {
            string option;

            Console.Clear();
            Console.WriteLine("|_____________________________________________________|");
            Console.WriteLine("|Choose an option below:                              |");
            Console.WriteLine("|Option 1: To pay an installment!                     |");
            Console.WriteLine("|Option 2: To pay all remaining installments!         |");
            Console.WriteLine("|Option 3: To cancel this purchase!                   |");
            Console.WriteLine("|Option 4: To renegotiate the remaining installments! |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BuyList[0].PayInstallment();
                    break;

                case "2":
                    BuyList[0].PayAll();
                    BuyList.RemoveAt(0);
                    Show();
                    break;

                case "3":
                    BuyList[0].CancelPurchase();
                    BuyList.RemoveAt(0);
                    Show();
                    break;

                case "4":
                    BuyList[0].UpdateInstallment();
                    break;

            }
            Console.ReadKey();
            PurchaseMenu();
        }

        public void StudentMenu()
        {
            var studentAccount = new StudentAccount();
            string option;

            Console.Clear();
            Console.WriteLine("|_____________________________________________________|");
            Console.WriteLine("|Choose an option below:                              |");
            Console.WriteLine("|Option 1: To pay an installment!                     |");
            Console.WriteLine("|Option 2: To pay all remaining installments!         |");
            Console.WriteLine("|Option 3: To cancel student enrollment!              |");
            Console.WriteLine("|Option 4: To renegotiate the remaining installments! |");
            Console.WriteLine("|Option 5: To get a discount!                         |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    StudentAccountList[0].PayInstallment();
                    break;

                case "2":
                    StudentAccountList[0].PayAll();
                    StudentAccountList.RemoveAt(0);
                    Show();
                    break;

                case "3":
                    StudentAccountList[0].CancelPurchase();
                    StudentAccountList.RemoveAt(0);
                    Show();
                    break;

                case "4":
                    StudentAccountList[0].UpdateInstallment();
                    break;

                case "5":
                    StudentAccountList[0].Discount(ref studentAccount);
                    break;

            }
            Console.ReadKey();
            StudentMenu();
        }

    }
}