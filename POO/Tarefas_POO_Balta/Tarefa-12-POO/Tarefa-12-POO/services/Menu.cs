using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Tarefa_12_POO.entities;

namespace Tarefa_11_POO.services
{
    public class Menu
    {

        public Menu()
        {
            EngineerList = new List<Engineer>();
            ManagerList = new List<Manager>();
        }

        public List<Engineer> EngineerList { get; set; }

        public List<Manager> ManagerList { get; set; }

        public int EmployeeQuantity { get; set; }

        public void Show()
        {
            var engineer = new Engineer();
            var manager = new Manager();
            string option;

            Console.Clear();
            Console.WriteLine("|___________________EMPLOYEE___________________|");
            Console.WriteLine("|Choose an option below:                       |");
            Console.WriteLine("|Option 1: Create an engineer type!            |");
            Console.WriteLine("|Option 2: Create a manager type!              |");
            Console.WriteLine("|Option 3: To view existing engineers!         |");
            Console.WriteLine("|Option 4: To view existing managers!          |");
            Console.WriteLine("|Option 5: To Exit!                            |");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    engineer.EnterCPF();
                    if (EngineerList.Count == 0)
                    {
                        engineer.EnterInfo();
                        CalcBonus(ref engineer, engineer, manager);
                        engineer.ShowInfo();
                        EngineerList.Add(engineer);
                    }
                    else
                    {
                        for (int i = 0; i < EngineerList.Count; i++)
                        {
                            if (EngineerList[i].CPF == engineer.CPF)
                            {
                                Console.Clear();
                                Console.WriteLine("There is already a employee with this CPF!");
                                Console.ReadKey();
                                Show();
                            }
                        }

                        engineer.EnterInfo();
                        CalcBonus(ref engineer, engineer, manager);
                        engineer.ShowInfo();
                        EngineerList.Add(engineer);
                    }
                    break;

                case "2":
                    manager.EnterCPF();
                    if (ManagerList.Count == 0)
                    {
                        manager.EnterInfo();
                        CalcBonus(ref manager, engineer, manager);
                        manager.ShowInfo();
                        ManagerList.Add(manager);
                    }
                    else
                    {
                        for (int i = 0; i < ManagerList.Count; i++)
                        {
                            if (ManagerList[i].CPF == manager.CPF || ManagerList.Count >= EngineerList.Count / 10)
                            {
                                Console.Clear();
                                Console.WriteLine("There is already a employee with this CPF!");
                                Console.WriteLine("And make it clear that only 1 manager is needed for 10 engineers");
                                Console.ReadKey();
                                Show();
                            }
                        }

                        manager.EnterInfo();
                        CalcBonus(ref manager, engineer, manager);
                        manager.ShowInfo();
                        ManagerList.Add(manager);
                    }
                    break;

                case "3":
                    if (EngineerList.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("____________________________");
                        Console.WriteLine("There is no engineer in DB |");
                        Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                        Console.ReadKey();
                        Show();
                    }
                    else
                    {
                        Console.Clear();
                        foreach (var item in EngineerList)
                        {
                            item.ShowInfo();
                        }
                    }
                    Console.ReadKey();
                    Show();
                    break;

                case "4":
                    if (ManagerList.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("___________________________");
                        Console.WriteLine("There is no manager in DB |");
                        Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                        Console.ReadKey();
                        Show();
                    }
                    else
                    {
                        Console.Clear();
                        foreach (var item in ManagerList)
                        {
                            Console.WriteLine("_________________________________________________");
                            Console.WriteLine($"Employee quantity: {EmployeeQuantity} employees!");
                            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
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
            EmployeeQuantity = EngineerList.Count + ManagerList.Count;
            Show();
        }

        private void CalcBonus<T>(ref T x, [Optional]Engineer engineer, [Optional]Manager manager)
        {
            if (x.GetType() == engineer.GetType())
            {
                engineer.CalculateBonus();

            }
            else if (x.GetType() == manager.GetType())
            {
                manager.CalculateBonus();
            }
        }

    }
}
