using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class Supplier: Stakeholder
    {
        public Supplier(string supplierName, string email, string phoneNumber) : base(email, phoneNumber)
        {
            SupplierName = supplierName;
        }
        public string SupplierName { get; set; }
        
    }
}
