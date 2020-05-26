using Microsoft.EntityFrameworkCore.Migrations;

namespace EventoTec.web.Migrations
{
    public partial class Eventss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Duretion",
                table: "Events",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Events",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Events",
                newName: "Duretion");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Events",
                newName: "Descripcion");
        }
    }
}
