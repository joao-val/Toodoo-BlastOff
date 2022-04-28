using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_06_POO.entities;

namespace Tarefa_06_POO.services
{
    public class Menu
    {
        public Menu()
        {
        }


        public void Show()
        {
            var vector = new Vectors();
            var matrix = new Matrices();
            var person = new Person();

            Console.Clear();
            Console.WriteLine("Choose an option below: ");
            Console.WriteLine("Opção 1: Play with a random one-dimensional vector!");
            Console.WriteLine("Opção 2: Play with a random matrix!");
            Console.WriteLine("Opção 3: Inform and consult the data of a person:");
            Console.WriteLine("Opção 4: To exit!");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    vector.FeedVector();
                    vector.ShowVectors();
                    vector.ShowIntegerVectors();
                    vector.MultiplyByIntegers();
                    break;

                case "2":
                    matrix.FeedMatrix();
                    matrix.Sum();
                    matrix.LowerHigherValue();
                    matrix.AverageMatrix();
                    break;

                case "3":
                    person.ShowPerson();
                    break;

                case "4": Environment.Exit(0); break;

                default: Show(); break;
            }

            Console.ReadKey();
            Show();
        }
    }
}