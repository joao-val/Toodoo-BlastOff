using FMInvestigacao.Data.Mappings;
using FMInvestigacao.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMInvestigacao.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Vilao>? Viloes { get; set; }
        public DbSet<Crime>? Crimes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server = localhost,1433; Database = Investigacao; User Id = sa; Password = Algar123; TrustServerCertificate = True;");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CrimeMap());
            modelBuilder.ApplyConfiguration(new VilaoMap());
        }
    }
}
