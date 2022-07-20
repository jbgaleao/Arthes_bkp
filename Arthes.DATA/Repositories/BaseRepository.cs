using Arthes.DATA.Data;
using Arthes.DATA.Interfaces.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Arthes.DATA.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
    {
        protected readonly ArthesContext _contexto;
        public bool _SaveChanges = true;


        public void Delete(T objeto)
        {
            _contexto.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
        }

        public void Delete(params object[] variavel)
        {
            object obj = GetById(variavel);
            Delete((T)obj);
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(params object[] variavel)
        {
            return _contexto.Set<T>().Find(variavel);
        }

        public T Insert(T objeto)
        {
            _contexto.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
            return objeto;
        }

        public void Savechanges()
        {
            _contexto.SaveChanges();
        }

        public T Update(T objeto)
        {
            _contexto.Entry(objeto).State = EntityState.Modified;
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
            return objeto;
        }
    }
}
