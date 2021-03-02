﻿using EssyWigs.Models;
using EssyWigs.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartProducts();
            _shoppingCart.ShoppingCartProducts = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.AllProducts.FirstOrDefault(p => p.ProductId == productId);
            
            if(selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("Index");
            
          }

          public RedirectToActionResult RemoveFromShoppingCart(int productId)
          {
                var selectedProduct = _productRepository.AllProducts.FirstOrDefault(p => p.ProductId == productId);
    
                if(selectedProduct != null)
                 {
                    _shoppingCart.RemoveFromCart(selectedProduct);
                 }
                 return RedirectToAction("Index");
           }
       }
}
