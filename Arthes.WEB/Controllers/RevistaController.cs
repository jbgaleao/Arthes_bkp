using Arthes.DATA.Models;
using Arthes.DATA.Services;

using Microsoft.AspNetCore.Mvc;

namespace Arthes.WEB.Controllers
{
    public class RevistaController : Controller
    {
        private readonly RevistaService oRevistaService = new RevistaService();

        public IActionResult Index()
        {
            List<ModelRevista> oModelRevista = oRevistaService.oRepositoryRevista.GetAll();
            return View(oModelRevista);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
