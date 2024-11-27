﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrdenesPPI.Infrastructure.Data;

#nullable disable

namespace OrdenesPPI.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241125165149_SeedStatesData")]
    partial class SeedStatesData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Activo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("TipoActivoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoActivoId");

                    b.ToTable("Activos", (string)null);
                });

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cuenta");
                });

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("descripcionEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CuentaId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<decimal>("MontoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Operacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ActivoId");

                    b.HasIndex("CuentaId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Orden");
                });

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Tipoactivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Tipoactivos", (string)null);
                });

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Activo", b =>
                {
                    b.HasOne("OrdenesPPI.Core.Entities.Tipoactivo", "Tipoactivo")
                        .WithMany("Activos")
                        .HasForeignKey("TipoActivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipoactivo");
                });

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Orden", b =>
                {
                    b.HasOne("OrdenesPPI.Core.Entities.Activo", "Activo")
                        .WithMany("Ordenes")
                        .HasForeignKey("ActivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrdenesPPI.Core.Entities.Cuenta", "Cuenta")
                        .WithMany("Ordenes")
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrdenesPPI.Core.Entities.Estado", "Estado")
                        .WithMany("Ordenes")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activo");

                    b.Navigation("Cuenta");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Activo", b =>
                {
                    b.Navigation("Ordenes");
                });

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Cuenta", b =>
                {
                    b.Navigation("Ordenes");
                });

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Estado", b =>
                {
                    b.Navigation("Ordenes");
                });

            modelBuilder.Entity("OrdenesPPI.Core.Entities.Tipoactivo", b =>
                {
                    b.Navigation("Activos");
                });
#pragma warning restore 612, 618
        }
    }
}
