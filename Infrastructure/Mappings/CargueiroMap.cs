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
        }
    }
}
