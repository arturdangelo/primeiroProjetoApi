using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoApi1.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoTabelaContato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TABELA_PRODUTOS",
                table: "TABELA_PRODUTOS");

            migrationBuilder.RenameTable(
                name: "TABELA_PRODUTOS",
                newName: "TABELA_PRODUTO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TABELA_PRODUTO",
                table: "TABELA_PRODUTO",
                column: "CODIGO_PRODUTO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TABELA_PRODUTO",
                table: "TABELA_PRODUTO");

            migrationBuilder.RenameTable(
                name: "TABELA_PRODUTO",
                newName: "TABELA_PRODUTOS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TABELA_PRODUTOS",
                table: "TABELA_PRODUTOS",
                column: "CODIGO_PRODUTO");
        }
    }
}
