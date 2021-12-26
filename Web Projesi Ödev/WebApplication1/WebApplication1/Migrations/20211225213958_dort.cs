using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class dort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tur",
                table: "Kus");

            migrationBuilder.DropColumn(
                name: "tur",
                table: "Kopek");

            migrationBuilder.DropColumn(
                name: "tur",
                table: "Kedi");

            migrationBuilder.DropColumn(
                name: "tur",
                table: "Balik");

            migrationBuilder.AlterColumn<string>(
                name: "adi",
                table: "Kus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "fiyat",
                table: "Kus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "adi",
                table: "Kopek",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "fiyat",
                table: "Kopek",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "adi",
                table: "Kedi",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "fiyat",
                table: "Kedi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "adi",
                table: "Balik",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "fiyat",
                table: "Balik",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fiyat",
                table: "Kus");

            migrationBuilder.DropColumn(
                name: "fiyat",
                table: "Kopek");

            migrationBuilder.DropColumn(
                name: "fiyat",
                table: "Kedi");

            migrationBuilder.DropColumn(
                name: "fiyat",
                table: "Balik");

            migrationBuilder.AlterColumn<int>(
                name: "adi",
                table: "Kus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tur",
                table: "Kus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "adi",
                table: "Kopek",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tur",
                table: "Kopek",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "adi",
                table: "Kedi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tur",
                table: "Kedi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "adi",
                table: "Balik",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tur",
                table: "Balik",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
