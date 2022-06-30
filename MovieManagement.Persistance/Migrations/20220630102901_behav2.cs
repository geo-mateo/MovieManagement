using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieManagement.Persistance.Migrations
{
    public partial class behav2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectorBiographies_Directors_DirectorId",
                table: "DirectorBiographies");

            migrationBuilder.DropIndex(
                name: "IX_DirectorBiographies_DirectorId",
                table: "DirectorBiographies");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "DirectorBiographies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 30, 12, 29, 1, 40, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.CreateIndex(
                name: "IX_DirectorBiographies_DirectorId",
                table: "DirectorBiographies",
                column: "DirectorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorBiographies_Directors_DirectorId",
                table: "DirectorBiographies",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectorBiographies_Directors_DirectorId",
                table: "DirectorBiographies");

            migrationBuilder.DropIndex(
                name: "IX_DirectorBiographies_DirectorId",
                table: "DirectorBiographies");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "DirectorBiographies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 30, 10, 17, 52, 373, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.CreateIndex(
                name: "IX_DirectorBiographies_DirectorId",
                table: "DirectorBiographies",
                column: "DirectorId",
                unique: true,
                filter: "[DirectorId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorBiographies_Directors_DirectorId",
                table: "DirectorBiographies",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id");
        }
    }
}
