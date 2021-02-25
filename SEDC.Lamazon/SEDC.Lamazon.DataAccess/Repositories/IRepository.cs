using System.Collections.Generic;

namespace SEDC.Lamazon.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}
