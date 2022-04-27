using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_05_POO.entities;

namespace Tarefa_05_POO.services
{
    public class Menu
    {

        public Menu()
        {
        }

        public void Show()
        {
            var celestialBodies = new CelestialBody[7];
            celestialBodies[0] = new CelestialBody();
            int asteroid = 0, planet = 0, nebula = 0;

            Console.WriteLine("Celestial Bodies Credentials.");
            Console.WriteLine("Enter the information of 6 celestial bodies:");


            for (int i = 1; i < 7; i++)
            {
                Console.Clear();
                Console.WriteLine($"Enter the information of the celestial body number {i}:");
                celestialBodies[i] = new CelestialBody();
                celestialBodies[i].CollectName();
                celestialBodies[i].CollectType();
                celestialBodies[i].CollectMass();
                celestialBodies[i].CollectSize();

                switch (celestialBodies[i].Type)
                {
                    case "asteroid": asteroid++; break;
                    case "planet": planet++; break;
                    case "nebula": nebula++; break;
                    default: asteroid++; break;
                }
            }

            Console.Clear();

            for (int i = 1; i < 7; i++)
            {
                celestialBodies[i].ViewData();
            }

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Were informed:\n {asteroid} asteroids| {planet} planets| {nebula} nebulas");
            Console.WriteLine("------------------------------------------------------------");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Type -1 to exit or any other key to continue:");
            if (Console.ReadLine() == "-1") Environment.Exit(0);
            Show();
        }
    }
}