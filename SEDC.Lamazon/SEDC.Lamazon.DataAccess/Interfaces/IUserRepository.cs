using SEDC.Lamazon.Domain.Models;

namespace SEDC.Lamazon.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        User GetByUsername(string username);
        User GetById(string id);
    }
}
