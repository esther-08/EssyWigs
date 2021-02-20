using EssyWigs.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EssyWigs.ViewModels;

namespace EssyWigs.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ISupplierRepository _supplierRepository;
       
        public ProductController(IProductRepository productRepository, ISupplierRepository supplierRepository)
        {
            _productRepository = productRepository;
            _supplierRepository = supplierRepository;
           
        }

        public ViewResult List()
        {
            ProductListViewModel productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.AllProducts;

            productListViewModel.SupplierWDiscount = "Ronah Hair";
            return View(productListViewModel);
        }
        public IActionResult Details(int productId)
        {
            var product = _productRepository.GetProductById(productId);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}


