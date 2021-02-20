using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class Supplier: Stakeholder
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        
    }
}
