using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trabajofinal2.Data.Migrations
{
    /// <inheritdoc />
    public partial class Migracion10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Especialidades_Escuelas_EscuelaId",
                table: "Especialidades");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Especialidades",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EscuelaId",
                table: "Especialidades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_Escuelas_EscuelaId",
                table: "Especialidades",
                column: "EscuelaId",
                principalTable: "Escuelas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Especialidades_Escuelas_EscuelaId",
                table: "Especialidades");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Especialidades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EscuelaId",
                table: "Especialidades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Especialidades_Escuelas_EscuelaId",
                table: "Especialidades",
                column: "EscuelaId",
                principalTable: "Escuelas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
