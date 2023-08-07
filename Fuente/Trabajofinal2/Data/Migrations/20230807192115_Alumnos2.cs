using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trabajofinal2.Data.Migrations
{
    /// <inheritdoc />
    public partial class Alumnos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Nacimiento",
                table: "Alumnos",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "Nacimiento",
                table: "Alumnos");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
