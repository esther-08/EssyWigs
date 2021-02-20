using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Length { get; set; }
        public string Colour { get; set; }
        public string Material { get; set; }
        public string HairType { get; set; }
        public string CapSize { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
