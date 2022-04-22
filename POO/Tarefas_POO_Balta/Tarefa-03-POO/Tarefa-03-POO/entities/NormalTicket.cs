using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_03_POO.entities.father;

namespace Tarefa_03_POO.entities
{
    public class NormalTicket : Ticket
    {
        public NormalTicket()
        {
        }

        public void printNormalTicket()
        {
            Console.Clear();
            Console.WriteLine("NORMAL TICKET!");
            Console.WriteLine("--------------------------");
            base.printCost();
        }

    }
}
