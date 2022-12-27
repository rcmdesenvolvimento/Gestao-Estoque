using GestaoEstoque.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestaoEstoque.Controllers
{
    [Route("[controller]")]
    public class CategoriaController : Controller
    {
        private readonly Contexto _contexto;

        public CategoriaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Categorias.ToListAsync());
        }

        [HttpGet]
        public IActionResult NovaCategoria()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NovaCategoria(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                await _contexto.Categorias.AddAsync(categoria);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);

        }

    }
}