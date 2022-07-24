using Microsoft.AspNetCore.Mvc;

namespace Arthes.WEB.Controllers
{
    public class ReceitaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
