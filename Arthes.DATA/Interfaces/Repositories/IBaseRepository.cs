namespace Arthes.DATA.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(params object[] variavel);
        T Insert(T objeto);
        T Update(T objeto);
        void Delete(T objeto);
        void Delete(params object[] variavel);
        void Savechanges();
    }
}
