using Arthes.DATA.Interfaces.RepositoryModels;
using Arthes.DATA.Models;

namespace Arthes.DATA.Repositories.RepositoryModels
{
    public class RepositoryRevista : RepositoryBase<ModelRevista>, IRepositoryRevista
    {
        public RepositoryRevista(bool SaveChances = true) : base(SaveChances)
        {

        }
    }
}
