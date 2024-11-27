using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdenesPPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixV_Ordenes1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            @"ALTER VIEW V_Ordenes AS SELECT O.Id As IdOrden,C.Id  As IdCuenta, C.Descripcion As NombreCuenta, A.Nombre As NombreActivo, " +
            "O.Cantidad,A.PrecioUnitario As Precio,E.descripcionEstado As Estado,O.MontoTotal, O.Operacion FROM Ordenes O " +
            "INNER JOIN Cuentas C ON C.Id = O.CuentaId " +
            "INNER JOIN Activos A ON A.Id = O.ActivoId " +
            "INNER JOIN Estados E ON E.Id = O.EstadoId; "
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
