using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class ProductOrderRepository: IProductOrderRepository
    {
        private readonly WigDbContext _wigDbContext;
        private readonly ShoppingCart _shoppingCart;
        
        public ProductOrderRepository(WigDbContext wigDbContext, ShoppingCart shoppingCart)
        {
            _wigDbContext = wigDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateProductOrder(ProductOrder productOrder)
        {
            productOrder.ProductOrderPlaced = DateTime.Now;
            _wigDbContext.ProductOrders.Add(productOrder);
            
            var shoppingCartProducts = _shoppingCart.ShoppingCartProducts;
            
            foreach (var shoppingCartProduct in shoppingCartProducts)
            {
                var orderDetail = new OrderDetail()
                {
                    ProductId = shoppingCartProduct.Product.ProductId,
                    ProductOrderId = productOrder.ProductOrderId,
                    Price = shoppingCartProduct.Product.Price,
                    Email = productOrder.Email,
                    PhoneNumber = productOrder.PhoneNumber
                   
                };
                _wigDbContext.OrderDetails.Add(orderDetail);
                
            }

            _wigDbContext.SaveChanges();
        }
    
    }
}
