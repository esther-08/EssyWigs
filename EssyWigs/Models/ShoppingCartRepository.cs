using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class ShoppingCartRepository
    {
        private readonly WigDbContext _wigDbContext;
        public ShoppingCartRepository(WigDbContext wigDbContext)
        {
            _wigDbContext = wigDbContext;
        }
        public IEnumerable<ShoppingCart> AllShoppingCarts
        {
            get
            {
                return _wigDbContext.ShoppingCarts;
            }
        }
    }
}
