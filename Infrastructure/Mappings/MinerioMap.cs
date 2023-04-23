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
    public class MinerioMap : IEntityTypeConfiguration<Minerio>
    {
        public void Configure(EntityTypeBuilder<Minerio> builder)
        {
            builder.ToTable("minerio");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .IsRequired(true);

            builder.Property(p => p.tipoMineral)
                .HasColumnName("tipoMineral")
                .IsRequired(true);

            builder.Property(p => p.caracteristica)
                .HasColumnName("caracteristica")
                .IsRequired(true);

            builder.Property(p => p.preco)
                .HasColumnName("preco")
                .IsRequired(true);

            builder.Property(p => p.peso)
                .HasColumnName("peso")
                .IsRequired(true);

            builder.Property(p => p.DtAlteracao)
                .HasColumnName("DtAlteracao")
                .IsRequired(true);

            builder.Property(p => p.LgUsuario)
                .HasColumnName("LgUsuario")
                .IsRequired(true);

        }
    }
}
