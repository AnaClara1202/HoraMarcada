using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HoraMarcada.Data;

namespace HoraMarcada.Controllers
{
    public class PessoaController : Controller
    {
        private readonly AppDbContext _context;
        public PessoaController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var lista = _context.Pessoas.Include(p => p.Usuario).ToList();
            return View(lista);
        }
    }
}