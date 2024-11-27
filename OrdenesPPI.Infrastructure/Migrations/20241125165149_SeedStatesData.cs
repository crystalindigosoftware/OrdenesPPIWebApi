using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdenesPPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedStatesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
               .Sql("INSERT INTO Estado (descripcionEstado) VALUES ('En proceso')");

            migrationBuilder
               .Sql("INSERT INTO Estado (descripcionEstado) VALUES ('Ejecutada')");

            migrationBuilder
               .Sql("INSERT INTO Estado (descripcionEstado) VALUES ('Cancelada')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
