using AutoMapper;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Lamazon.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public IEnumerable<ProductViewModel> GetAllProduct()
        {
            List<Product> products = _productRepository.GetAll().ToList();
            return _mapper.Map<List<Product>, List<ProductViewModel>>(products);
        }

        public ProductViewModel GetProductById(int id)
        {
            Product product = _productRepository.GetById(id);

            ProductViewModel model = _mapper.Map<ProductViewModel>(product);

            if (product != null)
            {
                return model;
            }
            else
            {
                throw new Exception($"Product with Id: {id} does not exist!");
            }
        }
    }
}
