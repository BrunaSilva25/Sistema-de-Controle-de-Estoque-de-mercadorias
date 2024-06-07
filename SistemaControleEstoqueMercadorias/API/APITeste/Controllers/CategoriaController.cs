using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace APITeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly EFDBContext _context;

        public CategoriaController(EFDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            return _context.Categoria.ToList();
        }

        [HttpPost]
        public ActionResult<Categoria> Post([FromBody] Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = categoria.Id }, categoria);
        }
    }
}
