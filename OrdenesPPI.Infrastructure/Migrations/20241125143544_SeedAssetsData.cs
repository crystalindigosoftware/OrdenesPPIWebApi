using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdenesPPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedAssetsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "Activos",
                type: "decimal(10,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Activos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder
            .Sql("INSERT INTO Activos (Ticker,Nombre,TipoActivoId,PrecioUnitario) VALUES ('APPL','Apple',1,177.97)");

            migrationBuilder
            .Sql("INSERT INTO Activos (Ticker,Nombre,TipoActivoId,PrecioUnitario) VALUES ('GOOGL','Alphabet Inc',1,138.21)");

            migrationBuilder
            .Sql("INSERT INTO Activos (Ticker,Nombre,TipoActivoId,PrecioUnitario) VALUES ('MSFT','Microsoft',1,329.04)");

            migrationBuilder
            .Sql("INSERT INTO Activos (Ticker,Nombre,TipoActivoId,PrecioUnitario) VALUES ('KO','Coca Cola',1,58.3)");

            migrationBuilder
            .Sql("INSERT INTO Activos (Ticker,Nombre,TipoActivoId,PrecioUnitario) VALUES ('WMT','Walmart',1,163.42)");

            migrationBuilder
            .Sql("INSERT INTO Activos (Ticker,Nombre,TipoActivoId,PrecioUnitario) VALUES ('AL30','BONOS ARGENTINA USD 2030 L.A.',2,307.4)");

            migrationBuilder
            .Sql("INSERT INTO Activos (Ticker,Nombre,TipoActivoId,PrecioUnitario) VALUES ('GD30','Bonos Globales Argentina Usd Step Up 2030',2,336.1)");

            migrationBuilder
            .Sql("INSERT INTO Activos (Ticker,Nombre,TipoActivoId,PrecioUnitario) VALUES ('Delta.Pesos','Delta Pesos Clase A',3,0.0181)");

            migrationBuilder
            .Sql("INSERT INTO Activos (Ticker,Nombre,TipoActivoId,PrecioUnitario) VALUES ('Fima.Premium','Fima Premium Clase A',3,0.0317)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "Activos",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)");
        }
    }
}
