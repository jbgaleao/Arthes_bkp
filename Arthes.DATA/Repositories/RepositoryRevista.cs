using Arthes.DATA.Interfaces;
using Arthes.DATA.Models;

namespace Arthes.DATA.Repositories
{
    public class RepositoryRevista : RepositoryBase<ModelRevista>, IRepositoryRevista
    {
        public RepositoryRevista(bool SaveChances = true) : base(SaveChances)
        {

        }
    }
}
