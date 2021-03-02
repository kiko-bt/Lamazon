using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Lamazon.DataAccess.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(LamazonDbContext context) : base(context) { }


        public IEnumerable<User> GetAll()
        {
            return _db.Users;
        }

        public User GetById(string id)
        {
            return _db.Users.SingleOrDefault(x => x.Id == id);
        }

        public User GetByUsername(string username)
        {
            return _db.Users.SingleOrDefault(x => x.UserName == username);
        }

        public int Insert(User entity)
        {
            _db.Users.Add(entity);
            return _db.SaveChanges();
        }

        public int Update(User entity)
        {
            _db.Users.Update(entity);
            return _db.SaveChanges();
        }

        public int Delete(string id)
        {
           User user = _db.Users.SingleOrDefault(x => x.Id == id);
            if (user == null)
                return -1;

            _db.Users.Remove(user);
            return _db.SaveChanges();
        }
    }
}
