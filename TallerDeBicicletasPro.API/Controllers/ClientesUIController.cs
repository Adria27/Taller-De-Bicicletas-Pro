using Microsoft.AspNetCore.Mvc;

namespace TallerDeBicicletasPro.API.Controllers
{
    public class ClientesUIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
