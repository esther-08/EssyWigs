using EssyWigs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Controllers
{
    public class ProductOrderController : Controller
    {
        private readonly IProductOrderRepository _productOrderRepository;
        private readonly ShoppingCart _shoppingCart;

        public ProductOrderController(IProductOrderRepository productOrderRepository, ShoppingCart shoppingCart)
        {
            _productOrderRepository = productOrderRepository;
            _shoppingCart = shoppingCart;
        }
       
        public IActionResult Checkout()
        {
            return View();
        }

              
        [HttpPost]
        public IActionResult Checkout(ProductOrder productOrder)
        {
            var items = _shoppingCart.GetShoppingCartProducts();
            _shoppingCart.ShoppingCartProducts = items;

            if (_shoppingCart.ShoppingCartProducts.Count == 0)
            {
                ModelState.AddModelError("", "Theres are no items in the cart, add products to proceed");
            }

            if (ModelState.IsValid)
            {
                _productOrderRepository.CreateProductOrder(productOrder);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutFinished");
            }
            return View(productOrder);
        }
        public IActionResult CheckoutFinished()
        {
            ViewBag.CheckoutFinishedMessage = "Your order has been registered. Your selected items will be shipped to you as soon as possible.";

            return View();
        }
    }
}
