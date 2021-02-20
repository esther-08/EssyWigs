using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EssyWigs.Models;

namespace EssyWigs.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string SupplierWDiscount{ get; set; }
    }
}
