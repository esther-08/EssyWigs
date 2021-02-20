using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EssyWigs.Models
{
    public class WigDbContext: DbContext
    {
        public WigDbContext(DbContextOptions<WigDbContext>options): base(options) 
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Stakeholder> Stakeholders { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Supplier>().HasData(new Supplier { SupplierId = 1, SupplierName = "Ronah Hair" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId =1,
                Name = "Lace Wig",
                Colour = "Black",
                Material = " Jane Human Hair",
                HairType = "Kinky",
                CapSize = "20cm",
                Price = 300f,
                Description = "Very soft human hair wig",
                SupplierId = 1,
                //SupplierWDiscount = true
               
        });

        }

    }
}
