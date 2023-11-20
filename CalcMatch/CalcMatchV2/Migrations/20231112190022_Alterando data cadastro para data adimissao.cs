using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcMatchV2.Migrations
{
    /// <inheritdoc />
    public partial class Alterandodatacadastroparadataadimissao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataCadastro",
                table: "Funcionarios",
                newName: "DataAdmissao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataAdmissao",
                table: "Funcionarios",
                newName: "DataCadastro");
        }
    }
}
