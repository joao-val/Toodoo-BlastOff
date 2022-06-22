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
    public class VilaoMap : IEntityTypeConfiguration<Vilao>
    {
        public void Configure(EntityTypeBuilder<Vilao> builder)
        {
            builder.ToTable("Vilao"); // Criando nome da tabela

            // configurando chave primaria
            builder.HasKey(x => x.IdVilao);
            builder.Property(x => x.IdVilao).ValueGeneratedOnAdd().UseIdentityColumn();

            // configurando os demais atributos de tabelas do SQLServer
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(45);

            builder.Property(x => x.NumCrime)
                .IsRequired()
                .HasColumnName("NumCrime")
                .HasColumnType("INT");
        }
    }
}
