using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Lamazon.DataAccess.Repositories
{
    public class OrderRepository : BaseRepository, IRepository<Order>
    {
        public OrderRepository(LamazonDbContext context) 
            :base(context) { }


        public IEnumerable<Order> GetAll()
        {
            return _db.Orders;
        }


        public Order GetById(int id)
        {
            return _db.Orders.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Order entity)
        {
            _db.Orders.Add(entity);
            return _db.SaveChanges();
        }

        public int Update(Order entity)
        {
            _db.Orders.Update(entity);
            return _db.SaveChanges();
        }

        public int Delete(int id)
        {
            Order order = _db.Orders.SingleOrDefault();
            if (order == null)
                return -1;

            _db.Orders.Remove(order);

            return _db.SaveChanges();
        }
    }
}
