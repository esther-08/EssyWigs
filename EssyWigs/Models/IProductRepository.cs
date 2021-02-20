using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; set; }
        Product GetProductById(int productId);
    }
}
