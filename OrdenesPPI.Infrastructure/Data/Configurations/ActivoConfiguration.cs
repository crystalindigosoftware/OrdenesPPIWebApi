using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdenesPPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Infrastructure.Data.Configurations
{
    public class ActivoConfiguration : IEntityTypeConfiguration<Activo>
    {
        public void Configure(EntityTypeBuilder<Activo> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .UseIdentityColumn();

            builder
                .Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(x => x.Ticker)
                .IsRequired()
                .HasMaxLength(32);

            builder
                .Property(x => x.PrecioUnitario)
                .IsRequired()
                .HasColumnType("decimal(10,4)");

            builder
              .HasOne(x => x.Tipoactivo)
              .WithMany(y => y.Activos)
              .HasForeignKey(x => x.TipoActivoId);

            builder
                .ToTable("Activos");
        }
    }
}
