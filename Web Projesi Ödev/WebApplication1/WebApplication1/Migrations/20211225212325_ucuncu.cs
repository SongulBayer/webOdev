using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class ucuncu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "adet",
                table: "Kus",
                newName: "adi");

            migrationBuilder.RenameColumn(
                name: "adet",
                table: "Kopek",
                newName: "adi");

            migrationBuilder.RenameColumn(
                name: "adet",
                table: "Kedi",
                newName: "adi");

            migrationBuilder.RenameColumn(
                name: "adet",
                table: "Balik",
                newName: "adi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "adi",
                table: "Kus",
                newName: "adet");

            migrationBuilder.RenameColumn(
                name: "adi",
                table: "Kopek",
                newName: "adet");

            migrationBuilder.RenameColumn(
                name: "adi",
                table: "Kedi",
                newName: "adet");

            migrationBuilder.RenameColumn(
                name: "adi",
                table: "Balik",
                newName: "adet");
        }
    }
}
