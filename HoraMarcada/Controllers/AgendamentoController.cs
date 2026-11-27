using HoraMarcada.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HoraMarcada.Controllers
{

    public class AgendamentoController : Controller
    {
        private readonly AppDbContext _context;

        public AgendamentoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // 3 e 4: pede ao Model, que usa o banco
            var lista = _context.Pessoas.Include(p => p.Usuario).ToList();

            // 6: entrega à View
            return View(lista);
        }
    }
}
