using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcMatchV2.Migrations
{
    /// <inheritdoc />
    public partial class Alteraçãonascolunasdeferias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ferias",
                table: "Funcionarios",
                newName: "TerminoFerias");

            migrationBuilder.AddColumn<DateTime>(
                name: "InicioFerias",
                table: "Funcionarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InicioFerias",
                table: "Funcionarios");

            migrationBuilder.RenameColumn(
                name: "TerminoFerias",
                table: "Funcionarios",
                newName: "Ferias");
        }
    }
}
