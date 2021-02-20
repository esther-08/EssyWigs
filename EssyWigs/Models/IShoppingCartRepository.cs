using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public interface IShoppingCartRepository
    {
        IEnumerable<ShoppingCart> shoppingCarts { get; set; }
    }
}
