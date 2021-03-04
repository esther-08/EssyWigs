using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class ShoppingCart
    {
        public readonly WigDbContext _wigDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartProduct> ShoppingCartProducts { get; set; }
        private ShoppingCart(WigDbContext wigDbContext)
        {
            _wigDbContext = wigDbContext;
        }
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            var context = services.GetService<WigDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }


        public void AddToCart(Product product, int totalCost)
        {
            var shoppingCartProduct =
                _wigDbContext.ShoppingCartProducts.SingleOrDefault(
                    s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);
            if (shoppingCartProduct == null)
            {
                shoppingCartProduct = new ShoppingCartProduct
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    TotalCost = 1
                };
                _wigDbContext.ShoppingCartProducts.Add(shoppingCartProduct);
            }
            else
            {
                shoppingCartProduct.TotalCost++;
            }
            _wigDbContext.SaveChanges();
        }
        public int RemoveFromCart(Product product)
        {
            var shoppingCartProduct =
                _wigDbContext.ShoppingCartProducts.SingleOrDefault(
                    s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);
            var localAmount = 0;
            if (shoppingCartProduct != null)
            {
                if (shoppingCartProduct.TotalCost > 1)
                {
                    shoppingCartProduct.TotalCost--;
                    localAmount = shoppingCartProduct.TotalCost;
                }

                else
                {
                    _wigDbContext.ShoppingCartProducts.Remove(shoppingCartProduct);
                }
            }
            _wigDbContext.SaveChanges();
            return localAmount;

        }
        public List<ShoppingCartProduct> GetShoppingCartProducts()
        {
            return ShoppingCartProducts ??
           (ShoppingCartProducts =
           _wigDbContext.ShoppingCartProducts.Where(c => c.ShoppingCartId==ShoppingCartId)
           .Include(s => s.Product)
           .ToList());
        }
        public void ClearCart()
        {
            var cartItems = _wigDbContext
                .ShoppingCartProducts
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _wigDbContext.ShoppingCartProducts.RemoveRange(cartItems);
            _wigDbContext.SaveChanges();
        }
        public double GetShoppingCartTotal()
        {
            var total = _wigDbContext.ShoppingCartProducts.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Product.Price * c.TotalCost).Sum();
            return total;
        }

    }
}
