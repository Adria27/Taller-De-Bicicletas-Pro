using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallerDeBicicletasPro.Persistence;
using TallerDeBicicletasPro.Persistence.Context;

namespace TallerDeBicicletasPro.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var graficoMes = _context.Reparaciones
                .GroupBy(r => r.Fecha.Month)
                .Select(g => new
                {
                    Mes = g.Key,
                    Total = g.Count()
                })
                .OrderBy(x => x.Mes)
                .ToList();

            ViewBag.GraficoMes = graficoMes;

            var graficoBicicletas = _context.Reparaciones
                .GroupBy(r => r.BicicletaId)
                .Select(g => new
                {
                    Bicicleta = g.Key,
                    Total = g.Count()
                })
                .OrderByDescending(x => x.Total)
                .Take(5)
                .ToList();

            ViewBag.GraficoBicicletas = graficoBicicletas;

            var graficoEstado = _context.Reparaciones
                .GroupBy(r => r.Estado)
                .Select(g => new
                {
                    Estado = g.Key,
                    Total = g.Count()
                })
                .ToList();

            ViewBag.GraficoEstado = graficoEstado;

            return View();
        }
    }
}
