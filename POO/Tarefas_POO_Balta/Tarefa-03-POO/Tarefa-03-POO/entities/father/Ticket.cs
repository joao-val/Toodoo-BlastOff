using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_03_POO.entities.father
{
    public abstract class Ticket
    {

        public Ticket()
        {
            Cost = 200.0;
        }

        public virtual double Cost { get; set; }

        public virtual void printCost()
        {
            Console.WriteLine($"The cost of ticket is: R${Math.Round(Cost, 2)}");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
