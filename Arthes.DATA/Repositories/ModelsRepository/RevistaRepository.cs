using Arthes.DATA.Interfaces.ModelsRepository;
using Arthes.DATA.Models.ModelsEntity;

namespace Arthes.DATA.Repositories.ModelsRepository
{
    public class RevistaRepository : BaseRepository<Revista>, IRevistaRepository
    {
        public RevistaRepository(bool SaveChances = true) : base(SaveChances)
        {

        }

        public void Delete(Revista objeto)
        {
            throw new NotImplementedException();
        }

        public Revista Insert(Revista objeto)
        {
            throw new NotImplementedException();
        }

        public Revista Update(Revista objeto)
        {
            throw new NotImplementedException();
        }

        List<Revista> Interfaces.IBaseRepository<Revista>.GetAll()
        {
            throw new NotImplementedException();
        }

        Revista Interfaces.IBaseRepository<Revista>.GetById(params object[] variavel)
        {
            throw new NotImplementedException();
        }
    }
}
