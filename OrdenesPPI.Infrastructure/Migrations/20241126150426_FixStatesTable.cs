using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdenesPPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixStatesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"Set Identity_insert Estados ON
                insert dbo.Estados (id, descripcionEstado)
                Values (0, 'En Proceso')
                set Identity_insert dbo.Estados OFF"
                );

            migrationBuilder.Sql(
                @"UPDATE Estados SET descripcionEstado = 'Ejecutada' WHERE Id=1"
                );

            migrationBuilder.Sql(
                @"UPDATE Estados SET descripcionEstado = 'Cancelada' WHERE Id=3"
                );

            migrationBuilder.Sql(
                @"DELETE FROM Estados WHERE Id=2"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
