using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_01.Data;
using Tarefa_01.Models;

namespace Tarefa_01.SpaceX
{
    public class Tasks
    {
        public void Insert(DataContext context)
        {
            var galaxy1 = new Galaxy()
            {
                Name = "Milky Way",
                Mass = 1.9m,
                Size = 105700m,
                Type = "Spiral"
            };

            var galaxy2 = new Galaxy()
            {
                Name = "Andromeda",
                Mass = 1.23m,
                Size = 220000m,
                Type = "Spiral"
            };

            var galaxy3 = new Galaxy()
            {
                Name = "Small Magellanic Cloud",
                Mass = 6.5m,
                Size = 7000m,
                Type = "Spiral"
            };

            context.Galaxies?.AddRange(galaxy1, galaxy2, galaxy3);
            //context.Galaxies.Add(galaxy1);
            //context.Galaxies.Add(galaxy2);
            //context.Galaxies.Add(galaxy3);

            var star1 = new Star()
            {
                Name = "Sun",
                Mass = 1.989m,
                Size = 1.392m,
                Luminosity = 1m,
                GalaxyId = 1
            };

            var star2 = new Star()
            {
                Name = "Kepler-438",
                Mass = 1.082m,
                Size = 723.84m,
                Luminosity = 0.044m,
                GalaxyId = 1
            };

            var star3 = new Star()
            {
                Name = "Gliese 667",
                Mass = 1.372m,
                Size = 974.4m,
                Luminosity = 0.0137m,
                GalaxyId = 1
            };

            context.Star.AddRange(star1, star2, star3);
            //context.Stars.Add(star1);
            //context.Stars.Add(star2);
            //context.Stars.Add(star3);

            context.SaveChanges();

            var planet1 = new Planet()
            {
                Name = "Earth",
                Mass = 5.9722m,
                Size = 12742m,
                Habitable = true,
                Distance = 0,
                StarId = 1
            };

            var planet2 = new Planet()
            {
                Name = "Kepler-438b",
                Mass = null,
                Size = 14271m,
                Habitable = true,
                Distance = 470,
                StarId = 2
            };

            var planet3 = new Planet()
            {
                Name = "Gliese 667 Cc",
                Mass = 2.621m,
                Size = 19113m,
                Habitable = true,
                Distance = 22,
                StarId = 3
            };

            var planet4 = new Planet()
            {
                Name = "Mars",
                Mass = 6.4174m,
                Size = 6779m,
                Habitable = false,
                Distance = 3.805m,
                StarId = 1
            };

            context.Planets?.AddRange(planet1, planet2, planet3, planet4);
            //context.Planets.Add(planet1);
            //context.Planets.Add(planet2);
            //context.Planets.Add(planet3);
            //context.Planets.Add(planet4);

            context.SaveChanges();
            Console.WriteLine("Data entered");
        }

        public void List(DataContext context)
        {
            var planet = context
                .Planets
                .AsNoTracking()
                .Include(planet => planet.Star)
                .Include(galaxy => galaxy.Star.Galaxy)
                .ToList();
        }

        public void DeletePlanet(DataContext context)
        {
            var planet = context.Planets?
                .Where(planet => planet.Habitable == false || planet.Distance > 30);
            context.Planets?.RemoveRange(planet);
            context.SaveChanges();
        }
    }
}
