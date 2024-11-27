using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdenesPPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
               .Sql("INSERT INTO Tipoactivos(Descripcion) VALUES ('Accion')");

            migrationBuilder
               .Sql("INSERT INTO Tipoactivos(Descripcion) VALUES ('Bono')");

            migrationBuilder
               .Sql("INSERT INTO Tipoactivos(Descripcion) VALUES ('FCI')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
