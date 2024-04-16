using ProjetoApi1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProjetoApi1.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options) 
        {

        }

        public DbSet<TABELA_PRODUTO> TABELA_PRODUTO {  get; set; }
    }
}
