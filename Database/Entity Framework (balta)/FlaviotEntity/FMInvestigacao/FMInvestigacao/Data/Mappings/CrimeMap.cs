using FMInvestigacao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMInvestigacao.Data.Mappings
{
    public class CrimeMap : IEntityTypeConfiguration<Crime>
    {
        public void Configure(EntityTypeBuilder<Crime> builder)
        {
            builder.ToTable("Crime");

            builder.HasKey(x => x.IdCrime);
            
            builder.Property(x => x.IdCrime)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(45);

            builder.Property(x =>x.Data)
                .IsRequired()
                .HasColumnName("Data")
                .HasColumnType("DATETIME");

            builder.Property(x => x.Local)
                .HasColumnName("Local")
                .HasColumnType("VARCHAR")
                .HasMaxLength(45);

            builder.Property(x => x.Duracao)
                .HasColumnName("Duracao")
                .HasColumnType("INT");

            // Criando relacionamento 1xN
            builder.HasOne(x => x.Vilao).WithMany(x => x.Crimes)
                .HasConstraintName("FK_Vilao_Crime")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
