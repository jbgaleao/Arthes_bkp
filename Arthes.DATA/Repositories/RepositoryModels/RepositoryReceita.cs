using Arthes.DATA.Interfaces.RepositoryModels;
using Arthes.DATA.Models;

namespace Arthes.DATA.Repositories.RepositoryModels
{
    public class RepositoryReceita : RepositoryBase<ModelReceita>, IRepositoryReceita
    {
        public RepositoryReceita(bool SaveChances = true) : base(SaveChances)
        {

        }
    }
}
