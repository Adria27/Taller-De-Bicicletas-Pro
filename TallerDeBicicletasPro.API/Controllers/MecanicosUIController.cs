using Microsoft.AspNetCore.Mvc;

namespace TallerDeBicicletasPro.API.Controllers
{
    public class MecanicosUIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
