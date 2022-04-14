using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05
{
    internal class Payroll
    {

        public Payroll()
        {
        }

        public void discounts()
        {
            var test1 = false;
            string valuePerHour, hoursPerMonth;
            double grossSalary, netSalary, discount = 0;
            int IR = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Payroll calculation.");
                Console.WriteLine("How much do you get paid per hour?(Decimals are separated by ',')");
                valuePerHour = Console.ReadLine();

                Console.WriteLine("How many hours do you work per month?");
                hoursPerMonth = Console.ReadLine();

                test1 = double.TryParse(valuePerHour, out double i) && double.TryParse(hoursPerMonth, out i);
            } while (test1 == false);

            grossSalary = double.Parse(valuePerHour) * double.Parse(hoursPerMonth);

            if (grossSalary < 900)
            {
                discount = 0;
                IR = 0;
            }
            else if (grossSalary > 900 && grossSalary <= 1500)
            {
                discount = grossSalary * 0.05;
                IR = 5;
            }
            else if (grossSalary > 1500 && grossSalary <= 2500)
            {
                discount = grossSalary * 0.10;
                IR = 10;
            }
            else if (grossSalary > 2500)
            {
                discount = grossSalary * 0.20;
                IR = 20;
            }

            var syndicate = grossSalary * 0.03;
            var IrValue = discount;
            var INSS = grossSalary * 0.10;
            var FGTS = grossSalary * 0.11;

            discount = discount + syndicate + INSS;
            netSalary = grossSalary - discount;

            Console.Clear();
            Console.WriteLine("Gross Salary (" + valuePerHour + " * " + hoursPerMonth + ") : R$" + Math.Round(grossSalary, 2));
            Console.WriteLine("Syndicate (3%): R$" + Math.Round(syndicate, 2));
            Console.WriteLine("IR ("+ IR +"%): R$"+ Math.Round(IrValue, 2));
            Console.WriteLine("INSS (10%): R$" + Math.Round(INSS, 2));
            
            Console.WriteLine();
            Console.WriteLine("FGTS (11%): R$" + Math.Round(FGTS, 2));
            Console.WriteLine("Total discounts: R$" + Math.Round(discount, 2));
            Console.WriteLine("Net Salary: R$" + Math.Round(netSalary, 2));
            Console.WriteLine();
        }
    }
}
