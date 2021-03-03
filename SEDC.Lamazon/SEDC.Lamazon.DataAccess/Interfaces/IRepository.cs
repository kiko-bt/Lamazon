using System.Collections.Generic;

namespace SEDC.Lamazon.DataAccess.Interfaces
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