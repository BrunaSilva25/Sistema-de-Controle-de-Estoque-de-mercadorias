using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace APITeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovimentacaoEstoqueController : ControllerBase
    {
        private readonly EFDBContext _context;

        public MovimentacaoEstoqueController(EFDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<MovimentacaoEstoque> Get()
        {
            return _context.MovimentacaoEstoque.ToList();
        }

        [HttpPost]
        public ActionResult<MovimentacaoEstoque> Post([FromBody] MovimentacaoEstoque movimentacaoEstoque)
        {
            _context.MovimentacaoEstoque.Add(movimentacaoEstoque);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = movimentacaoEstoque.ID }, movimentacaoEstoque);
        }
    }
}
