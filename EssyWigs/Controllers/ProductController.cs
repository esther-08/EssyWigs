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
        private Product productWDiscount;

        public ProductController(IProductRepository productRepository, ISupplierRepository supplierRepository)
        {
            _productRepository = productRepository;
            _supplierRepository = supplierRepository;
           
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
        public ViewResult List(string supplier)
        {
            IEnumerable<Product> products;
            //string productWDiscount;

            if (string.IsNullOrEmpty(supplier))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                //productWDiscount = "All products";
            }
            else
            {
                products = _productRepository.AllProducts.Where(p => p.Supplier.SupplierName == supplier)
                    .OrderBy(p => p.ProductId);
                productWDiscount = _productRepository.AllProducts.FirstOrDefault(s => s.Name == supplier);
            }
            return View(new ProductListViewModel
            {
                Products = products,
                ProductWDiscount = productWDiscount.ToString()
            });
        }
    }
}


