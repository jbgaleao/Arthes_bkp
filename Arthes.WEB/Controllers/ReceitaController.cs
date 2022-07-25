using Arthes.DATA.Enums;
using Arthes.DATA.Models;
using Arthes.DATA.Services;

using Microsoft.AspNetCore.Mvc;

namespace Arthes.WEB.Controllers
{
    public class ReceitaController : Controller
    {
        private readonly ReceitaService oReceitaService = new ReceitaService();
        public IActionResult Index()
        {
            AdicionaReceita();
            List<ModelReceita> oModelReceita = oReceitaService.oRepositoryReceita.GetAll();
            return View(oModelReceita);
        }

        private void AdicionaReceita()
        {
            ModelReceita receita = new ModelReceita()
            {
                Altura = 25,
                Dificuldade = Dificuldade.FACIL,
                Nome = "Renas",
                RevistaId = 6,
                _ModelRevista = new ModelRevista()
                {
                    Tema = "Natal 2021",
                    AnoEdicao = 2000,
                    MesEdicao = Mes.DEZEMBRO,
                    NumeroEdicao = 1
                }
            };
            oReceitaService.oRepositoryReceita.Insert(receita);
            oReceitaService.oRepositoryReceita.Savechanges();
        }
    }
}
