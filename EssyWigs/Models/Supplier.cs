using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class Supplier
    {
        public Supplier()
        {
        }

        public Supplier(string supplierName, string email, string phoneNumber)
        {
            SupplierName = supplierName;
            Email = email;
            PhoneNumber = phoneNumber;
            this.Products = new HashSet<Product>();
        }
      
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
