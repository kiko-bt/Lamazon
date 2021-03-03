using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Lamazon.DataAccess.Repositories
{
    public class ProductRepository : BaseRepository, IRepository<Product>
    {
        public ProductRepository(LamazonDbContext context) : base(context) { }


        public IEnumerable<Product> GetAll()
        {
            return _db.Products;
        }

        public Product GetById(int id)
        {
            return _db.Products.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Product entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}