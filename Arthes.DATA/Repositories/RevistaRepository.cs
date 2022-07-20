using Arthes.DATA.Interfaces;
using Arthes.DATA.Models;

namespace Arthes.DATA.Repositories
{
    public class RevistaRepository : BaseRepository<RevistaModel>, IRevistaRepository
    {
        public RevistaRepository(bool SaveChances = true) : base(SaveChances)
        {

        }
    }
}
