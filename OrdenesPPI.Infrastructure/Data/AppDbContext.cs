using Microsoft.EntityFrameworkCore;
using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.Views;
using OrdenesPPI.Infrastructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesPPI.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tipoactivo> Tipoactivos { get; set; }
        public DbSet<Activo> Activos { get; set; }

        public DbSet<Cuenta> Cuentas { get; set; }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<Orden> Ordenes { get; set; }

        //implementamos Vista con las ordenes generadas
        public DbSet<V_Ordenes> V_Ordenes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TipoactivoConfiguration());
            builder.ApplyConfiguration(new ActivoConfiguration());
            builder.ApplyConfiguration(new EstadoConfiguration());
            builder.ApplyConfiguration(new CuentaConfiguration());
            builder.ApplyConfiguration(new OrdenConfiguration());

            builder
                    .Entity<V_Ordenes>()
                    .ToView(nameof(V_Ordenes))
                    .HasKey(t => t.IdOrden);
        }
    }
}

