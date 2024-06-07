using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace APITeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly EFDBContext _context;

        public ProdutoController(EFDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _context.Produto.ToList();
        }

        [HttpPost]
        public ActionResult<Produto> Post([FromBody] Produto produto)
        {
            _context.Produto.Add(produto);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = produto.ID }, produto);
        }
    }
}
