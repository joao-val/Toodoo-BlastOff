using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class Counter
    {

        public Counter()
        { 
        }
        public void Menu()
        {
            string data;
            var test1 = false;
            var test2 = false;
            var test3 = false;
            do
            {
                Console.Clear();
                Console.WriteLine("S of seconds => (10s = 10 seconds)");
                Console.WriteLine("M of minutes => (1m = 1 minute)");
                Console.WriteLine("0 = Exit");
                Console.WriteLine("How long do you want to count?");

                data = Console.ReadLine().ToLower();
                
                if ((int.TryParse(data,out int x)) && (int.Parse(data) == 0))
                {
                    Environment.Exit(0);
                }

                test1 = ((data.Length < 2) == false);
                test2 = Int32.TryParse(data.Substring(0, data.Length - 1), out int i);
                
            } while ((test1 && test2) == false);
            
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type != 'm' && type != 's')
            {
                Console.WriteLine("Invalid type, write S for seconds or M for minutes");
                Console.ReadKey();
                Menu();
            }
            if (type == 'm')
            {
                multiplier = 60;
            }

            PreStart(time * multiplier);
        }

        private void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(500);
            Console.WriteLine("Set...");
            Thread.Sleep(500);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(time);
        }

        private void Start(int time)
        {
            while (time >= 0)
            {
                Console.Clear();
                Console.WriteLine(time.ToString() + "s");
                time--;
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch closed");
            Thread.Sleep(1500);
            Menu();
        }
    }
}