using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_06
{
    internal class LongJump
    {

        public LongJump()
        {
        }

        public void jump()
        {
            var test2 = false;
            var test3 = false;
            var testx = true; 
            var jumps = new string[6];
            string name;

            Console.Clear();
            Console.WriteLine("AVERAGE LONG JUMP (Esc to exit, any other key to continue).\n");
            
            if (Console.ReadKey().Key == ConsoleKey.Escape) Environment.Exit(0);

            Console.WriteLine("Enter the athlete's name: ");
            name = Console.ReadLine();

            do
            {
                Console.Clear();
                
                Console.WriteLine();
                Console.WriteLine("Enter the value for each of the 5 jumps (e.g=> 5,2m):\n");

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Enter the " + i + "st jump:");
                    jumps[i] = Console.ReadLine();
                }
                foreach (var j in jumps)
                {
                    testx = double.TryParse(j, out double x);
                }

            } while (testx == false);

            var first = double.Parse(jumps[1]);
            var second = double.Parse(jumps[2]);
            var third = double.Parse(jumps[3]);
            var fourth = double.Parse(jumps[4]);
            var fifth = double.Parse(jumps[5]);
            
            test2 = first > 15 || second > 15 || third > 15 || fourth > 15 || fifth > 15;
            test3 = first < 0 || second < 0 || third < 0 || fourth < 0 || fifth < 0;

            if (test2 == true)
            {
                Console.Clear();
                Console.WriteLine("Is he the Hulk?\nPlease enter human data.");
                Console.ReadKey();
                jump();
            }
            else if (test3 == true)
            {
                Console.Clear();
                Console.WriteLine("His jump cannot be negative!\nPlease enter the data correctly.");
                Console.ReadKey();
                jump();
            }

            double bestJump = 0, worstJump = 20, average = 0;

            for (int i = 1; i <= 5; i++)
            {
                if (worstJump > double.Parse(jumps[i]))
                {
                    worstJump = double.Parse(jumps[i]);
                }

                if (bestJump < double.Parse(jumps[i]))
                {
                    bestJump = double.Parse(jumps[i]);
                }
                average = average + double.Parse(jumps[i]);
            }
            average = (average - worstJump - bestJump) / 3;

            Console.Clear();
            Console.WriteLine("Athlete: " + name);
            Console.WriteLine();

            Console.WriteLine("First jump: " + first + "m");
            Console.WriteLine("Second jump: " + second + "m");
            Console.WriteLine("Third jump: " + third + "m");
            Console.WriteLine("Fourth jump: " + fourth + "m");
            Console.WriteLine("Fifth jump: " + fifth + "m \n");
            Console.WriteLine();

            Console.WriteLine("Best jump: " + bestJump + "m");
            Console.WriteLine("Worst jump: " + worstJump + "m");
            Console.WriteLine("Average of the other jumps: " + Math.Round(average, 2) + "m \n");            
            Console.WriteLine();

            Console.WriteLine("Final result: ");
            Console.WriteLine(name + ": " + Math.Round(average, 2) + "m \n");

            Console.ReadKey();
            jump();
        }
    }
}
