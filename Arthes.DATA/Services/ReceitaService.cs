using Arthes.DATA.Repositories.RepositoryModels;

namespace Arthes.DATA.Services
{
    public class ReceitaService
    {
        public RepositoryReceita oRepositoryReceita { get; set; }

        public ReceitaService()
        {
            oRepositoryReceita = new RepositoryReceita();
        }
    }
}
