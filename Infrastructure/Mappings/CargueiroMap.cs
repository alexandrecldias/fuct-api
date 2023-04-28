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
    public class CargueiroMap : IEntityTypeConfiguration<Cargueiro>
    {
        public void Configure(EntityTypeBuilder<Cargueiro> builder)
        {
            builder.ToTable("Cargueiro");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .IsRequired(true);

            builder.Property(p => p.classe)
                .HasColumnName("classe")
                .IsRequired(true);

            builder.Property(p => p.capacidade)
                 .HasColumnName("capacidade")
                 .IsRequired(true);

            builder.Property(p => p.status)
                 .HasColumnName("status")
                 .IsRequired(true);

            builder.Property(p => p.IdMinerio)
                 .HasColumnName("IdMinerio")
                 .IsRequired(true);

            builder.HasOne(p => p.Minerio).WithOne(c => c.Cargueiro).HasForeignKey<Minerio>(c => c.Id);

            builder.HasOne(p => p.Transporte).WithOne(c => c.Cargueiro).HasForeignKey<Transporte>(c => c.idCargueiro);

        }
    }
}
