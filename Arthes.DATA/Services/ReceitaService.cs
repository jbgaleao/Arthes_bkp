using Arthes.DATA.Repositories.ModelsRepository;

namespace Arthes.DATA.Services
{
    public class ReceitaService
    {
        public ReceitaRepository oRepositoryReceita { get; set; }

        public ReceitaService()
        {
            oRepositoryReceita = new ReceitaRepository();
        }
    }
}
