using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class ShoppingCartProduct
    {
        public int ShoppingCartProductId { get; set; }
        public Product Product { get; set; }
        public int TotalCost { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
