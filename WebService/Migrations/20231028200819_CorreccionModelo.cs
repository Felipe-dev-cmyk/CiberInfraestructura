using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebService.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionModelo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Alumnos",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Edad",
                table: "Alumnos",
                newName: "edad");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Alumnos",
                newName: "apellido");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Alumnos",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Alumnos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "edad",
                table: "Alumnos",
                newName: "Edad");

            migrationBuilder.RenameColumn(
                name: "apellido",
                table: "Alumnos",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Alumnos",
                newName: "Id");
        }
    }
}
