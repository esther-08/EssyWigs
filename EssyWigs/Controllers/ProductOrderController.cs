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
        // GET: ProductOrderController
        public IActionResult Checkout()
        {
            return View();
        }

        // GET: ProductOrderController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ProductOrderController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

       
        [HttpPost]
        public IActionResult Checkout(ProductOrder productOrder)
        {
            var products = _shoppingCart.GetShoppingCartProducts();
            _shoppingCart.ShoppingCartProducts = products;

            if (_shoppingCart.ShoppingCartProducts.Count == 0)
            {
                ModelState.AddModelError("", "Theres are no items in the cart, add to proceed");
            }

            if (ModelState.IsValid)
            {
                _productOrderRepository.CreateProductOrder(productOrder);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(productOrder);
        
        }

        public IActionResult CheckoutFinished()
        {
            ViewBag.CheckoutFinishedMessage = "Your order has been registered. Your selected items will be shipped to you as soon as possible.";

            return View();
        }
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProductOrderController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProductOrderController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProductOrderController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProductOrderController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
