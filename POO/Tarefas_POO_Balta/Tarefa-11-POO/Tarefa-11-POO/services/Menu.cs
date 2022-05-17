using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tarefa_11_POO.entities;

namespace Tarefa_11_POO.services
{
    public class Menu
    {

        public Menu()
        {
            LegalPersonList = new List<LegalPerson>();
            PhysicalPersonList = new List<PhysicalPerson>();
        }

        public List<LegalPerson> LegalPersonList { get; set; }

        public List<PhysicalPerson> PhysicalPersonList { get; set; }

        public void Show()
        {
            var legalPerson = new LegalPerson();
            var physicalPerson = new PhysicalPerson();
            string option;

            Console.Clear();
            Console.WriteLine("|_____________________LOAN_____________________|");
            Console.WriteLine("|Choose an option below:                       |");
            Console.WriteLine("|Option 1: Loan for physical person!           |");
            Console.WriteLine("|Option 2: Loan for legal person!              |");
            Console.WriteLine("|Option 3: To view existing physical persons!  |");
            Console.WriteLine("|Option 4: To view existing legal persons!     |");
            Console.WriteLine("|Option 5: To Exit!                            |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    physicalPerson.EnterCPF();
                    if (PhysicalPersonList.Count == 0)
                    {
                        physicalPerson.EnterInfo();
                        CalcInstallment(ref physicalPerson, physicalPerson, legalPerson);
                        physicalPerson.ShowInfo();
                        PhysicalPersonList.Add(physicalPerson);
                    }
                    else
                    {
                        for (int i = 0; i < PhysicalPersonList.Count; i++)
                        {
                            if (PhysicalPersonList[i].CPF == physicalPerson.CPF || PhysicalPersonList[i].Number == physicalPerson.Number)
                            {
                                Console.Clear();
                                Console.WriteLine("There is already a contract in this CPF or this contract already exists!");
                                Console.ReadKey();
                                Show();
                            }
                        }

                        physicalPerson.EnterInfo();
                        CalcInstallment(ref physicalPerson, physicalPerson, legalPerson);
                        physicalPerson.ShowInfo();
                        PhysicalPersonList.Add(physicalPerson);
                    }

                    break;

                case "2":
                    legalPerson.EnterCNPJ();
                    if (LegalPersonList.Count == 0)
                    {
                        legalPerson.EnterInfo();
                        CalcInstallment(ref legalPerson, physicalPerson, legalPerson);
                        legalPerson.ShowInfo();
                        LegalPersonList.Add(legalPerson);
                    }
                    else
                    {
                        for (int i = 0; i < LegalPersonList.Count; i++)
                        {
                            if (LegalPersonList[i].CNPJ == legalPerson.CNPJ || LegalPersonList[i].Number == legalPerson.Number)
                            {
                                Console.Clear();
                                Console.WriteLine("There is already a contract in this CNPJ or this contract already exists!");
                                Console.ReadKey();
                                Show();
                            }
                        }
                        legalPerson.EnterInfo();
                        CalcInstallment(ref legalPerson, physicalPerson, legalPerson);
                        legalPerson.ShowInfo();
                        LegalPersonList.Add(legalPerson);
                    }
                    break;

                case "3":
                    if (PhysicalPersonList.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("There is no contract in this CPF");
                        Console.ReadKey();
                        Show();
                    }
                    else
                    {
                        Console.Clear();
                        foreach (var item in PhysicalPersonList)
                        {
                            item.ShowInfo();
                        }
                    }
                    Console.ReadKey();
                    Show();
                    break;

                case "4":
                    if (LegalPersonList.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("There is no contract in this CNPJ");
                        Console.ReadKey();
                        Show();
                    }
                    else
                    {
                        Console.Clear();
                        foreach (var item in LegalPersonList)
                        {
                            item.ShowInfo();
                        }
                    }
                    Console.ReadKey();
                    Show();
                    break;

                case "5":
                    Environment.Exit(0);
                    break;
            }
            Show();
        }

        public void CalcInstallment<T>(ref T x, [Optional]PhysicalPerson physicalPerson, [Optional]LegalPerson legalPerson)
        {

            if (x.GetType() == physicalPerson.GetType())
            {
                physicalPerson.CalculateInstallment(physicalPerson.Value, physicalPerson.Deadline);

            }
            else if (x.GetType() == legalPerson.GetType())
            {
                legalPerson.CalculateInstallment(legalPerson.Value, legalPerson.Deadline);
            }
        }

    }
}
