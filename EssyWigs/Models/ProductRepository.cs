using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly WigDbContext _wigDbContext;
      

        public ProductRepository(WigDbContext wigDbContext)
        {
            _wigDbContext = wigDbContext;
        }
        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _wigDbContext.Products.Include(s => s.Supplier);
            }
        }

        public IEnumerable<Product> ProductWDiscount
        {
            get
            {
                return _wigDbContext.Products.Where(p => p.ProductWDiscount);
            }
        }

        IEnumerable<Product> IProductRepository.AllProducts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Product GetProductById(int productId)
        {
            return _wigDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }

      
    }
}
