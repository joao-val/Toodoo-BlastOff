using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarefa_12_POO.entities
{
    public class Engineer : Employee
    {

        public string Crea { get; set; }

        public string Category { get; set; }

        public string CurrentProject { get; set; }

        public void EnterCPF()
        {
            Regex testCPF = new Regex(@"^[\d]{3}\.[\d]{3}\.[\d]{3}-[\d]{2}$");
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("___________________________________________________");
                Console.WriteLine("Enter the employee's CPF (format xxx.xxx.xxx-xx): |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                CPF = Console.ReadLine();
            } while (!testCPF.IsMatch(CPF));
        }
        public void EnterInfo()
        {
            Regex testCrea = new Regex(@"^[\d]{9}-[\d]$");
            Regex testName = new Regex(@"^[A-Za-zÁ-Úá-ú]{2,15}\s[A-Za-zÁ-Úá-ú\s]+$");

            bool test = false, test2 = false, test3 = false;
            string salary;

            do
            {
                Console.Clear();
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("You chose the employee: Engineer.                                     |");
                Console.WriteLine("Enter the information requested by the system(in the correct format)! |");
                Console.WriteLine("Enter the employee salary (between R$3000,00 to R$11000,00):          |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                salary = Console.ReadLine();
                Console.WriteLine("\nEnter the employee name:");
                Name = Console.ReadLine();
                test = double.TryParse(salary, out double x) && double.Parse(salary) >= 3000
                    && double.Parse(salary) <= 11000 && testName.IsMatch(Name);
            } while (test == false);
            Salary = double.Parse(salary);

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("_______________________________________________________");
                Console.WriteLine("Enter the crea (in the format xxxxxxxxx-x):           |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                Crea = Console.ReadLine();
            } while (!testCrea.IsMatch(Crea));

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("______________________________________________________________");
                Console.WriteLine("Enter the category of engineer (mechanical| electric| civil) |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                Category = Console.ReadLine().ToLower();

                test2 = Category == "mechanical" || Category == "electric" || Category == "civil";
            } while (test2 == false);

            switch (Category)
            {
                case "mechanical": CurrentProject = "Construction"; break;

                case "electric": CurrentProject = "Workshop"; break;

                case "civil": CurrentProject = "Electrical network"; break;
            }

        }

        public override void CalculateBonus()
        {
            Bonus = Salary * 0.05;
        }

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("____________________EMPLOYEE____________________");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Salary: R$ {Math.Round(Salary, 2)}");
            Console.WriteLine($"Bonus: R$ {Math.Round(Bonus, 2)}");
            Console.WriteLine($"Crea: {Crea}");
            Console.WriteLine($"Category: {Category} engineer!");
            Console.WriteLine($"Current Project: {CurrentProject}!");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }

    }
}
