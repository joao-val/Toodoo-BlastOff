using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_11_POO.entities
{
    public abstract class Contract
    {

        public Contract()
        {
        }

        public int Number { get; set; }

        public string Contractor { get; set; }

        public float Value { get; set; }

        public int Deadline { get; set; }

        public float Installment { get; set; }

        public virtual void EnterInfo()
        {
        }

        public virtual void CalculateInstallment(float value, int deadline)
        {
        }

        public virtual void ShowInfo()
        {
        }

    }
}
