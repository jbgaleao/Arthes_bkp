

using Arthes.DATA.Interfaces.ModelsRepository;
using Arthes.DATA.Models.ModelsEntity;

namespace Arthes.DATA.Repositories.ModelsRepository
{
    public class ReceitaRepository : BaseRepository<Receita>, IReceitaRepository
    {
        public ReceitaRepository(bool SaveChances = true) : base(SaveChances)
        {

        }

        public void Delete(Receita objeto)
        {
            throw new NotImplementedException();
        }

        public Receita Insert(Receita objeto)
        {
            throw new NotImplementedException();
        }

        public Receita Update(Receita objeto)
        {
            throw new NotImplementedException();
        }

        List<Receita> Interfaces.IBaseRepository<Receita>.GetAll()
        {
            throw new NotImplementedException();
        }

        Receita Interfaces.IBaseRepository<Receita>.GetById(params object[] variavel)
        {
            throw new NotImplementedException();
        }
    }
}
