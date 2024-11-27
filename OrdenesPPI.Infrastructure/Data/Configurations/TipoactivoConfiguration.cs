using OrdenesPPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Infrastructure.Data.Configurations
{
    public class TipoactivoConfiguration : IEntityTypeConfiguration<Tipoactivo>
    {
        public void Configure(EntityTypeBuilder<Tipoactivo> builder) {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .UseIdentityColumn();

            builder
                .Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .ToTable("Tipoactivos");

        }
    }
}
