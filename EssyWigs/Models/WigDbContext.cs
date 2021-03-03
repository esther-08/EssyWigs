using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EssyWigs.Models
{
    public class WigDbContext: IdentityDbContext<IdentityUser>
    {
       

        public WigDbContext(DbContextOptions<WigDbContext>options): base(options) 
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartProduct> ShoppingCartProducts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public IEnumerable<ShoppingCart> ShoppingCarts { get; internal set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
            //.HasRequired(p => p.Supplier)
            //.WithMany(s => s.Products)
            //.HasForeignKey(p => p.SupplierId)
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, Name = "Front Lace Wig", Colour = "Maroon", Material = "Ronah Synthetic Hair", HairType = "Kinky", CapSize = "15cm", Price = 200f, Description = "Fluffy synthetic wig", ProductWDiscount = true, SupplierId= 1 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 2, Name = "Lace Wig", Colour = "Black", Material = "Jane Human Hair", HairType = "Kinky", CapSize = "20cm", Price = 300f, Description = "Very soft human hair wig. Can be washed and styled.", ProductWDiscount = true, SupplierId = 2 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 3, Name = "Beautiful Blonde Wavy", Colour = "Blonde", Material = "Jane Human Hair", HairType = "Coily", CapSize = "10cm", Price = 160f, Description = "soft human hair wig",  ProductWDiscount = true, SupplierId = 2 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 4, Name = "Brown Wavy Wig", Colour = "Brown", Material = "Jane Human Hair", HairType = "Wavy", CapSize = "15cm", Price = 400f, Description = "Wavy wig with failry good hair volume for right fitting.", ProductWDiscount = false, SupplierId = 2 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 5, Name = "Full Wave Wig", Colour = "Gold", Material = "Jane Human Hair", HairType = "Kinky", CapSize = "25cm", Price = 350f, Description = "This wig adds alot of brightness to one's look.",  ProductWDiscount = false, SupplierId = 1 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 6, Name = "Remy Human Hair", Colour = "Gold", Material = "Jane Human Hair", HairType = "Curly", CapSize = "15cm", Price = 100f, Description = "Beautiful hair piece.", ProductWDiscount = true, SupplierId = 2 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 7, Name = "Remy Human Hair", Colour = "Gold", Material = "Ronah Synthetic Hair", HairType = "Curly", CapSize = "15cm", Price = 100f, Description = "Beautiful hair piece.", ProductWDiscount = true, SupplierId = 1 });

            //Supplier = new Supplier("Ronah Hair", "ronahhair@gmail.com", "0401553313"),
            //Supplier = new Supplier("Unique Hair Ltd", "uniquehair@gmail.com", "0423000433"),
            //Supplier.SupplierId = 1,
            //Supplier = new Supplier("Unique Hair Ltd", "uniquehair@gmail.com", "0423000433"),
            //SupplierId = 1,
            //Supplier = new Supplier("Unique Hair Ltd", "uniquehair@gmail.com", "0423000433"),
            //SupplierId = 1,

            modelBuilder.Entity<Supplier>().HasData(new Supplier { SupplierId = 1, SupplierName = "Ronah Hair", Email = "ronahhair@gmail.com", PhoneNumber = "0401553313" });
            modelBuilder.Entity<Supplier>().HasData(new Supplier { SupplierId = 2, SupplierName = "Unique Hair Ltd", Email = "uniquehair@gmail.com", PhoneNumber = "0423000433" });
           
        }


    }
}
