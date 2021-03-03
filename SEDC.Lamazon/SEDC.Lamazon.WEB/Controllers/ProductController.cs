using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using Serilog;

namespace SEDC.Lamazon.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Authorize(Roles = "user")]
        public IActionResult Products()
        {
            Log.Information("Fetching all products started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            List<ProductViewModel> products = _productService.GetAllProducts().ToList();

            stopwatch.Stop();
            Log.Information($"Time for fetching all products: {stopwatch.ElapsedMilliseconds}ms");
            return View(products);
        }
    }
}