using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdenesPPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedAccountData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //INSERT INTO Cuenta (Descripcion) VALUES ('Marcos Gonzalez')
            migrationBuilder
               .Sql("INSERT INTO Cuenta (Descripcion) VALUES ('Marcos Gonzalez')");

            migrationBuilder
               .Sql("INSERT INTO Cuenta (Descripcion) VALUES ('Augusto Gonzalez')");

            migrationBuilder
               .Sql("INSERT INTO Cuenta (Descripcion) VALUES ('Leandro Gonzalez')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
