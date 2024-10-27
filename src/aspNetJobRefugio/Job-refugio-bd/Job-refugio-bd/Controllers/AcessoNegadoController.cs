using Microsoft.AspNetCore.Mvc;

namespace Job_refugio_bd.Controllers
{
    public class AcessoNegadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
