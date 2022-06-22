using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa_01.Models;

namespace Tarefa_01.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Galaxy>? Galaxies { get; set; }
        public DbSet<Star>? Star { get; set; }
        public DbSet<Planet>? Planets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server = localhost,1433; Database = SpaceX; User Id = sa; Password = Algar123; TrustServerCertificate = True;");
        }

    }
}
