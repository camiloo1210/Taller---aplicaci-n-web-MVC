using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller1.Migrations
{
    /// <inheritdoc />
    public partial class Migracion3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estadio",
                table: "Equipo");

            migrationBuilder.AddColumn<int>(
                name: "IdEstadio",
                table: "Equipo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_IdEstadio",
                table: "Equipo",
                column: "IdEstadio");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Estadio_IdEstadio",
                table: "Equipo",
                column: "IdEstadio",
                principalTable: "Estadio",
                principalColumn: "IdEstadio",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Estadio_IdEstadio",
                table: "Equipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_IdEstadio",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "IdEstadio",
                table: "Equipo");

            migrationBuilder.AddColumn<string>(
                name: "Estadio",
                table: "Equipo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
