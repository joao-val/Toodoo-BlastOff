using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_03_POO.entities;

namespace Tarefa_03_POO.services
{
    public class Menu
    {

        public Menu()
        {
        }

        public void show()
        {
            var test = false;
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("_________________________________");
                Console.WriteLine("Choose one of the option below: |");
                Console.WriteLine("Option 1: Choose a ticket!      |");
                Console.WriteLine("Option 2: Exit!                 |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                option = Console.ReadLine();
                test = int.TryParse(option, out int x);
            }while(test == false);

            switch (int.Parse(option))
            {
                case 1:
                    ticket();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    show();
                    break;
            }
            show();
        }

        private void ticket()
        {
            NormalTicket normalTicket = new NormalTicket();
            VIPTicket vipTicket = new VIPTicket();
            BottomBox bottomBox = new BottomBox();
            TopBox topBox = new TopBox();
            var test = false;
            string option;

            do
            {
                Console.Clear();
                Console.WriteLine("_____________________________________");
                Console.WriteLine("Which ticket do you want to choose? |");
                Console.WriteLine("Option 1: Normal ticket!            |");
                Console.WriteLine("Option 2: Bottom Box ticket!        |");
                Console.WriteLine("Option 3: Top Box ticket!           |");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                option = Console.ReadLine();
                test = int.TryParse(option, out int x);
            } while (test == false);
            switch (int.Parse(option))
            {
                case 1: 
                    normalTicket.printNormalTicket();
                    break;
                
                case 2:
                    bottomBox.VIPTicketPrice();
                    bottomBox.printLocation();
                    break;

                case 3:
                    topBox.topBoxTicketPrice();
                    break;

                default: ticket(); break;
            }
        }

    }
}
