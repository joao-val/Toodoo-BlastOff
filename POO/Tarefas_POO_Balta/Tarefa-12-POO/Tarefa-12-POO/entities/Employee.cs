using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_12_POO.entities
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public string CPF { get; set; }

        public double Salary { get; set; }

        public double Bonus { get; set; }

        public virtual void CalculateBonus()
        {
        }
    }
}
