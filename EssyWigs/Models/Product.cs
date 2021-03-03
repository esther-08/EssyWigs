using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int productId, string name, string colour, string material, string hairType, string capSize, double price, string description, Supplier supplier, bool productWDiscount)
        {
            ProductId = productId;
            Name = name;
            Colour = colour;
            Material = material;
            HairType = hairType;
            CapSize = capSize;
            Price = price;
            Description = description;
            

            Supplier = supplier;
            ProductWDiscount = productWDiscount;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        //public string Length { get; set; }
        public string Colour { get; set; }
        public string Material { get; set; }
        public string HairType { get; set; }
        public string CapSize { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public bool ProductWDiscount { get; set; }
       
        
        
    }
}
