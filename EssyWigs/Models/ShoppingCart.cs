using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public List<Product>Products { get; set; }
        public int TotalCost { get; set; }
        public Customer Customer { get; set; }
    }
}
