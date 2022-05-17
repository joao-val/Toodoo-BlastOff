using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarefa_12_POO.entities
{
    public class Manager : Employee
    {

        public Manager()
        {
        }

        public float specialPassword { get; set; }

        public int EmployeeQuantity { get; set; }

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
            Regex testPassword = new Regex(@"^[\d]{4,6}$");
            Regex testName = new Regex(@"^[A-Za-zÁ-Úá-ú]{2,15}\s[A-Za-zÁ-Úá-ú\s]+$");

            bool test = false;
            string salary, password;

            do
            {
                Console.Clear();
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("You chose the employee: Manager.                                      |");
                Console.WriteLine("Enter the information requested by the system(in the correct format)! |");
                Console.WriteLine("Enter the employee salary (between R$11000,00 to R$20000,00 digits):  |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                salary = Console.ReadLine();
                Console.WriteLine("\nEnter the employee name:");
                Name = Console.ReadLine();
                test = double.TryParse(salary, out double x) && double.Parse(salary) >= 11000 
                    && double.Parse(salary) <= 20000 && testName.IsMatch(Name);
            } while (test == false);
            Salary = double.Parse(salary);

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("_______________________________________________________");
                Console.WriteLine("Enter the special password (between 4 to 6 digits):   |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                password = Console.ReadLine();
            } while (!testPassword.IsMatch(password));
            specialPassword = float.Parse(password);
        }

        public override void CalculateBonus()
        {
            Bonus = Salary * 0.10;
        }

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("____________________EMPLOYEE____________________");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Salary: R$ {Math.Round(Salary, 2)}");
            Console.WriteLine($"Bonus: R$ {Math.Round(Bonus, 2)}");
            Console.WriteLine($"Password: {specialPassword}");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }

    }
}
