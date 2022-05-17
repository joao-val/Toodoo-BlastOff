using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_09_POO.entities;

namespace Tarefa_09_POO.services
{
    public class Menu
    {

        public Menu()
        {
            VisitorList = new List<Visitor>();
            PremiumVisitorList = new List<PremiumVisitor>();
        }

        public List<Visitor> VisitorList { get; set; }
        
        public List<PremiumVisitor> PremiumVisitorList { get; set; }
        


        public void Show()
        {
            var visitor = new Visitor();
            var premiumVisitor = new PremiumVisitor();
            string option;

            Console.Clear();
            Console.WriteLine("|____________________MUSEUM____________________|");
            Console.WriteLine("|Choose an option below:                       |");
            Console.WriteLine("|Option 1: Enter as a regular visitor!         |");
            Console.WriteLine("|Option 2: Enter as a premium visitor!         |");
            Console.WriteLine("|Option 3: To view existing visitors!          |");
            Console.WriteLine("|Option 4: To access the visitor menu!         |");
            Console.WriteLine("|Option 5: To access the premium visitor menu! |");
            Console.WriteLine("|Option 6: To Exit!                            |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    visitor.FillCPF();
                    if (VisitorList.Count == 0)
                    {
                        visitor.FillInformations();
                        visitor.Theme();
                        VisitorList.Add(visitor);
                    }
                    else
                    {
                        for (int i = 0; i < VisitorList.Count; i++)
                        {
                            if (VisitorList[i].CPF == visitor.CPF)
                            {
                                Console.Clear();
                                Console.WriteLine("This visitor already exists!");
                                Console.ReadKey();
                                Show();
                            }
                        }

                        visitor.FillInformations();
                        visitor.Theme();
                        VisitorList.Add(visitor);
                    }
                    break;

                case "2":
                    premiumVisitor.FillCPF();
                    if (VisitorList.Count == 0)
                    {
                        premiumVisitor.FillInformations();
                        premiumVisitor.Theme();
                        premiumVisitor.FillInMealTicket();
                        PremiumVisitorList.Add(premiumVisitor);
                    }
                    else
                    {
                        for (int i = 0; i < PremiumVisitorList.Count; i++)
                        {
                            if (PremiumVisitorList[i].CPF == premiumVisitor.CPF)
                            {
                                Console.Clear();
                                Console.WriteLine("This visitor already exists!");
                                Console.ReadKey();
                                Show();
                            }
                        }

                        premiumVisitor.FillInformations();
                        premiumVisitor.Theme();
                        premiumVisitor.FillInMealTicket();

                        for (int i = 0; i < PremiumVisitorList.Count; i++)
                        {
                            if (PremiumVisitorList[i].MealTicketNumber == premiumVisitor.MealTicketNumber)
                            {
                                Console.Clear();
                                Console.WriteLine("This meal ticket already exists!");
                                premiumVisitor.FillInMealTicket();
                                Console.ReadKey();
                                i=0;
                            }
                        }

                        PremiumVisitorList.Add(premiumVisitor);
                    }
                    break;

                case "3":
                    Console.Clear();
                    if (VisitorList.Count > 0)
                    {
                        Console.WriteLine("Existing regular visitors are:");
                        foreach (Visitor visitors in VisitorList)
                        {
                            visitors.ShowAllInformations();
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no common visitor to the museum!");
                        Console.ReadKey();
                    }

                    Console.WriteLine();
                    if (PremiumVisitorList.Count > 0)
                    {
                        Console.WriteLine("Existing premium visitors are:");
                        foreach (PremiumVisitor visitors in PremiumVisitorList)
                        {
                            visitors.ShowAllInformations();
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no premium visitor to the museum!");
                        Console.ReadKey();
                    }
                    break;

                case "4":
                    VisitorMenu();
                    break;

                case "5":
                    PremiumVisitorMenu();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;
            }
            Show();
        }

        public void VisitorMenu()
        {
            var visitor = new Visitor();
            string option;
            var test = false;

            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("First enter the CPF of the visitor who wants to access the menu: |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            visitor.FillCPF();

            foreach (var visitors in VisitorList)
            {
                test = visitors.CPF == visitor.CPF && VisitorList.Count > 0;
            }

            if (test == true)
            {
                var visitorCPF = VisitorList.Where(x => x.CPF == visitor.CPF);
                Console.Clear();
                Console.WriteLine("|___________________________VISITOR__________________________|");
                Console.WriteLine("|Choose an option below:                                     |");
                Console.WriteLine("|Option 1: See how many items are on display in museum!      |");
                Console.WriteLine("|Option 2: Back to main menu!                                |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

                option = Console.ReadLine();
                foreach (var visit in visitorCPF)
                {
                    switch (option)
                    {
                        case "1":
                            visit.ShowItems();
                            break;

                        case "2":
                            Show();
                            break;
                    }

                    VisitorMenu();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("_____________________________________________________________");
                Console.WriteLine("Does not contain any visitor with this CPF in the database! |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                Console.ReadKey();
                Show();
            }
        }

        public void PremiumVisitorMenu()
        {
            var premiumVisitor = new PremiumVisitor();
            string option;
            var test = false;

            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("First enter the CPF of the visitor who wants to access the menu: |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            premiumVisitor.FillCPF();

            foreach (var premiumVisitors in PremiumVisitorList)
            {
                test = premiumVisitors.CPF == premiumVisitor.CPF && PremiumVisitorList.Count > 0;
            }

            if (test == true)
            {
                var visitorCPF = PremiumVisitorList.Where(x => x.CPF == premiumVisitor.CPF);
                Console.Clear();
                Console.WriteLine("|___________________________VISITOR__________________________|");
                Console.WriteLine("|Choose an option below:                                     |");
                Console.WriteLine("|Option 1: See how many items are on display in museum!      |");
                Console.WriteLine("|Option 2: To use the food voucher!                          |");
                Console.WriteLine("|Option 3: Back to main menu!                                |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

                option = Console.ReadLine();
                foreach (var visit in visitorCPF)
                {
                    switch (option)
                    {
                        case "1":
                            visit.ShowItems();
                            break;

                        case "2":
                            visit.Spent();
                            break;

                        case "3":
                            Show();
                            break;
                    }

                    PremiumVisitorMenu();
                }
            }
        }
    }
}
