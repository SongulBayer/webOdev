using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class ikinci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "adet",
                table: "Kus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "adet",
                table: "Kopek",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "adet",
                table: "Kedi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "adet",
                table: "Balik",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adet",
                table: "Kus");

            migrationBuilder.DropColumn(
                name: "adet",
                table: "Kopek");

            migrationBuilder.DropColumn(
                name: "adet",
                table: "Kedi");

            migrationBuilder.DropColumn(
                name: "adet",
                table: "Balik");
        }
    }
}
