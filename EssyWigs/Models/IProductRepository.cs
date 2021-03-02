using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; set; }
        IEnumerable<Product> ProductWDiscount { get; }

        Product GetProductById(int productId);
    }
}
