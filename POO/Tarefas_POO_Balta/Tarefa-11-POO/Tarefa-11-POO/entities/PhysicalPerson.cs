using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarefa_11_POO.entities
{
    public class PhysicalPerson : Contract
    {

        public PhysicalPerson()
        {
        }

        public string CPF { get; set; }

        public int Age { get; set; }

        public void EnterCPF()
        {
            Regex testCPF = new Regex(@"^[\d]{3}\.[\d]{3}\.[\d]{3}-[\d]{2}$");
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Enter the company's CPF (format xxx.xxx.xxx-xx):");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                CPF = Console.ReadLine();
            } while (!testCPF.IsMatch(CPF));
        }

        public override void EnterInfo()
        {
            Regex contractNumber = new Regex(@"^[\d]{3,5}$");
            Regex testName = new Regex(@"^[A-Za-zÁ-Úá-ú]{2,15}\s[A-Za-zÁ-Úá-ú\s]+$");

            bool test = false, test2 = false, test3 = false;
            string number, value, deadline, age;

            do
            {
                Console.Clear();
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("You chose the contract physical person.                               |");
                Console.WriteLine("Enter the information requested by the system(in the correct format)! |");
                Console.WriteLine("Enter the contract number (between 3 to 5 digits):                    |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                number = Console.ReadLine();
                Console.WriteLine("\nEnter the contractor name:");
                Contractor = Console.ReadLine();
                test = contractNumber.IsMatch(number) && testName.IsMatch(Contractor);
            } while (test == false);
            Number = int.Parse(number);

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("_______________________________________________________");
                Console.WriteLine("Enter the contract value (between R$100 to R$500000): |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                value = Console.ReadLine();
                Console.WriteLine("Enter the deadline (between 3 and 60 months):");
                deadline = Console.ReadLine();

                test2 = float.TryParse(value, out float x) && float.Parse(value) >= 100 && float.Parse(value) <= 500000
                    && int.TryParse(deadline, out int y) && int.Parse(deadline) >= 3 && int.Parse(deadline) <= 60;
            } while (test2 == false);

            Value = float.Parse(value);
            Deadline = int.Parse(deadline);

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter the age (must be between 16 and 90 years):");
                age = Console.ReadLine();
                
                test3 = int.TryParse(age, out int x) && int.Parse(age) >= 16 && int.Parse(age) <=90;
            } while (test3 == false);
            Age = int.Parse(age);
        }

        public override void CalculateInstallment(float value, int deadline)
        {
            switch (Age)
            {
                case <= 30:
                    Installment = (value / deadline) + 1;
                    break;

                case <= 40:
                    Installment = (value / deadline) + 2;
                    break;

                case <= 50:
                    Installment = (value / deadline) + 3;
                    break;

                case > 50:
                    Installment = (value / deadline) + 4;
                    break;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("____________________CONTRACT____________________");
            Console.WriteLine($"Contractor: {Contractor}");
            Console.WriteLine($"Contract value: R$ {Math.Round(Value, 2)}");
            Console.WriteLine($"Deadline: {Deadline} months");
            Console.WriteLine($"Installment value: R$ {Math.Round(Installment, 2)}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }

    }
}
