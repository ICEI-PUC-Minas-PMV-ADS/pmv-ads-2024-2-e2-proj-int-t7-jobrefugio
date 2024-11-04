using Microsoft.AspNetCore.Mvc;

namespace Job_refugio_bd.Controllers
{
    public class GuiaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GuiaRefugiado()
        {
            return View();
        }
    }
}
