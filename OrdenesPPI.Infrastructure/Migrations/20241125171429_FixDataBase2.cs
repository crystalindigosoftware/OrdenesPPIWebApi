using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdenesPPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixDataBase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orden_Activos_ActivoId",
                table: "Orden");

            migrationBuilder.DropForeignKey(
                name: "FK_Orden_Cuenta_CuentaId",
                table: "Orden");

            migrationBuilder.DropForeignKey(
                name: "FK_Orden_Estado_EstadoId",
                table: "Orden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orden",
                table: "Orden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estado",
                table: "Estado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuenta",
                table: "Cuenta");

            migrationBuilder.RenameTable(
                name: "Orden",
                newName: "Ordenes");

            migrationBuilder.RenameTable(
                name: "Estado",
                newName: "Estados");

            migrationBuilder.RenameTable(
                name: "Cuenta",
                newName: "Cuentas");

            migrationBuilder.RenameIndex(
                name: "IX_Orden_EstadoId",
                table: "Ordenes",
                newName: "IX_Ordenes_EstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Orden_CuentaId",
                table: "Ordenes",
                newName: "IX_Ordenes_CuentaId");

            migrationBuilder.RenameIndex(
                name: "IX_Orden_ActivoId",
                table: "Ordenes",
                newName: "IX_Ordenes_ActivoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ordenes",
                table: "Ordenes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estados",
                table: "Estados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuentas",
                table: "Cuentas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordenes_Activos_ActivoId",
                table: "Ordenes",
                column: "ActivoId",
                principalTable: "Activos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordenes_Cuentas_CuentaId",
                table: "Ordenes",
                column: "CuentaId",
                principalTable: "Cuentas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordenes_Estados_EstadoId",
                table: "Ordenes",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordenes_Activos_ActivoId",
                table: "Ordenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordenes_Cuentas_CuentaId",
                table: "Ordenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordenes_Estados_EstadoId",
                table: "Ordenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ordenes",
                table: "Ordenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estados",
                table: "Estados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cuentas",
                table: "Cuentas");

            migrationBuilder.RenameTable(
                name: "Ordenes",
                newName: "Orden");

            migrationBuilder.RenameTable(
                name: "Estados",
                newName: "Estado");

            migrationBuilder.RenameTable(
                name: "Cuentas",
                newName: "Cuenta");

            migrationBuilder.RenameIndex(
                name: "IX_Ordenes_EstadoId",
                table: "Orden",
                newName: "IX_Orden_EstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Ordenes_CuentaId",
                table: "Orden",
                newName: "IX_Orden_CuentaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ordenes_ActivoId",
                table: "Orden",
                newName: "IX_Orden_ActivoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orden",
                table: "Orden",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estado",
                table: "Estado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cuenta",
                table: "Cuenta",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orden_Activos_ActivoId",
                table: "Orden",
                column: "ActivoId",
                principalTable: "Activos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orden_Cuenta_CuentaId",
                table: "Orden",
                column: "CuentaId",
                principalTable: "Cuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orden_Estado_EstadoId",
                table: "Orden",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
