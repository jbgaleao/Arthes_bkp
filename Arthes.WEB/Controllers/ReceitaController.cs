using Arthes.DATA.Enums;
using Arthes.DATA.Models.ModelsEntity;
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
            List<Receita> oModelReceita = oReceitaService.oRepositoryReceita.GetAll();
            return View(oModelReceita);
        }

        private void AdicionaReceita()
        {
            Receita receita = new Receita()
            {
                Altura = 25,
                NivelDificuldade = Dificuldade.FACIL,
                Nome = "Renas",
                RevistaId = 6,
                Revista = new Revista()
                {
                    Tema = "Natal 2021",
                    AnoEdicao = "2000",
                    MesEdicao = Mes.DEZEMBRO,
                    NumeroEdicao = 1
                }
            };
            oReceitaService.oRepositoryReceita.Insert(receita);
            oReceitaService.oRepositoryReceita.Savechanges();
        }
    }
}
