using SEDC.Lamazon.Domain.Models;
using System.Collections.Generic;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
    }
}
