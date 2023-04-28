using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappings
{
    public class TransporteMap : IEntityTypeConfiguration<Transporte>
    {
        public void Configure(EntityTypeBuilder<Transporte> builder)
        {
            builder.ToTable("Transporte");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .IsRequired(true);

            builder.Property(p => p.dataHoraSaida)
                .HasColumnName("dataHoraSaida")
                .IsRequired(true);

            builder.Property(p => p.dataHoraRetorno)
                .HasColumnName("dataHoraRetorno")
                .IsRequired(true);

            builder.Property(p => p.quantidadeMinerais)
                .HasColumnName("quantidadeMinerais")
                .IsRequired(true);

            builder.Property(p => p.valorCarga)
                .HasColumnName("valorCarga")
                .IsRequired(true);

            builder.Property(p => p.tipoMinerio)
                .HasColumnName("tipoMineral")
                .IsRequired(true);

            builder.Property(p => p.idCargueiro)
                .HasColumnName("idCargueiro")
                .IsRequired(true);

            builder.HasOne(p => p.Cargueiro).WithOne(c => c.Transporte).HasForeignKey<Cargueiro>(c => c.Id);

        }
    }
}
