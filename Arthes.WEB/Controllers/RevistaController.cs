using Arthes.DATA.Models;
using Arthes.DATA.Services;

using Microsoft.AspNetCore.Mvc;

namespace Arthes.WEB.Controllers
{
    public class RevistaController : Controller
    {
        private readonly RevistaService oRevistaService = new RevistaService();
        private readonly DateTime _dataAtual = DateTime.Now;
        private DateTime DataAtual
        {
            get { return _dataAtual; }
        }


        public IActionResult Index()
        {
            List<ModelRevista> oModelRevista = oRevistaService.oRepositoryRevista.GetAll();
            return View(oModelRevista);
        }

        public IActionResult Create()
        {
            //ViewData["MesAtual"] = DataAtual.Month;
            //ViewData["AnoAtual"] = DataAtual.Year;

            return View();
        }

        [HttpPost]
        public IActionResult Create(ModelRevista rev)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oRevistaService.oRepositoryRevista.Insert(rev);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {
            ModelRevista oRevista = oRevistaService.oRepositoryRevista.GetById(Id);
            return View(oRevista);
        }

        public IActionResult Edit(int Id)
        {
            ModelRevista oRevista = oRevistaService.oRepositoryRevista.GetById(Id);
            return View(oRevista);
        }

        [HttpPost]
        public IActionResult Update(ModelRevista rev)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oRevistaService.oRepositoryRevista.Update(rev);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            oRevistaService.oRepositoryRevista.Delete(Id);
            return RedirectToAction("Index");
        }



    }
}
