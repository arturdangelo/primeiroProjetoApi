using ProjetoApi1.Context;
using ProjetoApi1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoContext _context;
        
        public ProdutoController(ProdutoContext context)
        {
            _context = context;
        }

        [HttpPost("CadastrarProduto")]
        public IActionResult Create(TABELA_PRODUTO produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
            return Ok(produto);
        }
    }
}
