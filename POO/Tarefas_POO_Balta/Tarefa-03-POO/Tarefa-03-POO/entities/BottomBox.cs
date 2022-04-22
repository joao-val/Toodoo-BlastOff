using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_03_POO.entities
{
    public class BottomBox : VIPTicket
    {
        public BottomBox()
        {
        }

        public string TicketLocation { get; set; }

        public string accessLocation()
        {
            Console.Clear();
            TicketLocation = "Ground floor";
            Console.WriteLine("To acesses the ticket location (Bottom Box) you must:");
            Console.WriteLine("Walk to corridor number 2 and go down the stairs to the ground floor, there you can present your ticket!");
            Console.ReadKey();
            return TicketLocation;
        }

        public void printLocation()
        {
            accessLocation();
            Console.Clear();
            Console.WriteLine($"The ticket location (Bottom Box) is:\n{TicketLocation}");
            Console.ReadKey();
        }

    }
}
