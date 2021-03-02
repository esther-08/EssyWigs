using EssyWigs.Models;
using EssyWigs.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> ProductWDiscount { get; private set; }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductWDiscount = _productRepository.ProductWDiscount
            };
            
            return View(homeViewModel);
        }

    }
}
