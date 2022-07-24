using Arthes.DATA.Repositories.RepositoryModels;

namespace Arthes.DATA.Services
{
    public class RevistaService
    {
        public RepositoryRevista oRepositoryRevista { get; set; }

        public RevistaService()
        {
            oRepositoryRevista = new RepositoryRevista();
        }
    }
}
