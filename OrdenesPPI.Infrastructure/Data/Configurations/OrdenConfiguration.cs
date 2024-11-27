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
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .UseIdentityColumn();

            builder
                .Property(x => x.Cantidad)
                .HasColumnType("decimal(10,4)")
                .IsRequired();

            builder
                .Property(x => x.Operacion)
                .HasColumnType("varchar(5)")
                .HasMaxLength(5)
                .IsRequired();

            builder
                .Property(x => x.Comisiones)
                .HasColumnType("decimal(10,4)");

            builder
                .Property(x => x.Impuestos)
                .HasColumnType("decimal(10,4)");

            builder
                .Property(x => x.Monto)
                .HasColumnType("decimal(10,4)");

            builder
                .Property(x => x.MontoTotal)
                .HasColumnType("decimal(10,4)");

            builder
               .HasOne(x => x.Estado)
               .WithMany(y => y.Ordenes)
               .HasForeignKey(x => x.EstadoId);

            builder
               .HasOne(x => x.Activo)
               .WithMany(y => y.Ordenes)
               .HasForeignKey(x => x.ActivoId);

            builder
               .HasOne(x => x.Cuenta)
               .WithMany(y => y.Ordenes)
               .HasForeignKey(x => x.CuentaId);

            builder
                .ToTable("Ordenes");
        }
    }
}
