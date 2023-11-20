using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcMatchV2.Migrations
{
    /// <inheritdoc />
    public partial class incluindoferiasnatabelafuncionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Ferias",
                table: "Funcionarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ferias",
                table: "Funcionarios");
        }
    }
}
