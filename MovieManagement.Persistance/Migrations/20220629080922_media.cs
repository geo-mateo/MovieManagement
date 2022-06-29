using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieManagement.Persistance.Migrations
{
    public partial class media : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DirectorName_LastName",
                table: "Directors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "DirectorName_FirstName",
                table: "Directors",
                newName: "FirstName");

            migrationBuilder.AlterColumn<int>(
                name: "PremierYear",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 2000,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfBirth",
                table: "DirectorBiographies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 29, 10, 9, 22, 468, DateTimeKind.Local).AddTicks(3513));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceOfBirth",
                table: "DirectorBiographies");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Directors",
                newName: "DirectorName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Directors",
                newName: "DirectorName_FirstName");

            migrationBuilder.AlterColumn<int>(
                name: "PremierYear",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 23, 18, 19, 56, 794, DateTimeKind.Local).AddTicks(859));
        }
    }
}
