using Arthes.DATA.Repositories.ModelsRepository;

namespace Arthes.DATA.Services
{
    public class RevistaService
    {
        public RevistaRepository oRepositoryRevista { get; set; }

        public RevistaService()
        {
            oRepositoryRevista = new RevistaRepository();
        }
    }
}
