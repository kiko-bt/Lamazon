using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using System.Collections.Generic;

namespace SEDC.Lamazon.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            Product product = _productRepository.GetById(id);

            if (product != null)
            {
                return product;
            }
            else
            {
                throw new System.Exception($"Product with Id: {id} does not exist!");
            }
        }
    }
}
