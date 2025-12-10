using Microsoft.AspNetCore.Mvc;

namespace TallerDeBicicletasPro.API.Controllers
{
    public class BicicletasUIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
