using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoApi1.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoTabelaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TABELA_PRODUTOS",
                columns: table => new
                {
                    CODIGO_PRODUTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRECO_PRODUTO = table.Column<double>(type: "float", nullable: false),
                    QUANTIDADE_PRODUTO = table.Column<double>(type: "float", nullable: false),
                    SITUACAO_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABELA_PRODUTOS", x => x.CODIGO_PRODUTO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TABELA_PRODUTOS");
        }
    }
}
