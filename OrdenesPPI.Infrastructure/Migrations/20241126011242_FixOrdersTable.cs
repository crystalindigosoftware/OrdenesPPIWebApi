using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdenesPPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Comisiones",
                table: "Ordenes",
                type: "decimal(10,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Impuestos",
                table: "Ordenes",
                type: "decimal(10,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Monto",
                table: "Ordenes",
                type: "decimal(10,4)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comisiones",
                table: "Ordenes");

            migrationBuilder.DropColumn(
                name: "Impuestos",
                table: "Ordenes");

            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Ordenes");
        }
    }
}
