using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarefa_11_POO.entities
{
    public class LegalPerson : Contract
    {
        public LegalPerson()
        {
        }

        public string CNPJ { get; set; }

        public string StateRegistration { get; set; }

        public void EnterCNPJ()
        {
            Regex testCPNJ = new Regex(@"^[\d]{2}\.[\d]{3}\.[\d]{3}/[\d]{4}-[\d]{2}$");
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter the company's CNPJ (format xx.xxx.xxx/xxxx-xx):");
                CNPJ = Console.ReadLine();
            } while (!testCPNJ.IsMatch(CNPJ));
        }

        public override void EnterInfo()
        {
            Regex contractNumber = new Regex(@"^[\d]{3,5}$");
            Regex testName = new Regex(@"^[A-Za-zÁ-Úá-ú]{2,15}\s[A-Za-zÁ-Úá-ú\s]+$");
            Regex testRegistration = new Regex(@"^[\d]{8}-[\d]{2}$");

            bool test = false, test2 = false, test3 = false;
            string number, value, deadline;

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
                Console.WriteLine("Enter the contract value (between R$100 to R$500000):");
                value = Console.ReadLine();
                Console.WriteLine("Enter the deadline (between 3 and 60 months):");
                deadline = Console.ReadLine();
                
                test2 =  float.TryParse(value, out float x) && float.Parse(value) >= 100 && float.Parse(value) <= 500000 
                    && int.TryParse(deadline, out int y) && int.Parse(deadline) >= 3 && int.Parse(deadline) <= 60;
            }while (test2 == false);
            Value = float.Parse(value);
            Deadline = int.Parse(deadline);

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Enter state registration (format xxxxxxxx-xx): |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                StateRegistration = Console.ReadLine();
                test3 = testRegistration.IsMatch(StateRegistration);
            } while (test3 == false);

        }

        public override void CalculateInstallment(float value, int deadline)
        {
            Installment = (value / deadline) + 3;
        }

        public override void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("____________________CONTRACT____________________");
            Console.WriteLine($"Contractor: {Contractor}");
            Console.WriteLine($"Contract value: R$ {Math.Round(Value, 2)}");
            Console.WriteLine($"Deadline: {Deadline} months");
            Console.WriteLine($"Installment value: R$ {Math.Round(Installment, 2)}");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.ReadKey();
        }
    }
}
