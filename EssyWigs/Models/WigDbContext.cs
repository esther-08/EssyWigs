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
           
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, Name = "Front Lace Wig", Colour = "Blonde", Material = "Ronah Synthetic Hair", HairType = "Kinky", CapSize = "15cm", Price = 200f, Description = "Fluffy synthetic wig", Image= "/Images/BlondeHair.jpg", ProductWDiscount = true, SupplierId= 1 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 2, Name = "Lace Wig", Colour = "Black", Material = "Jane Human Hair", HairType = "Kinky", CapSize = "20cm", Price = 300f, Description = "Very soft human hair wig. Can be washed and styled.", Image="/Images/Logo.jpg", ProductWDiscount = true, SupplierId = 2 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 3, Name = "Beautiful Blonde Wavy", Colour = "Blonde", Material = "Jane Human Hair", HairType = "Coily", CapSize = "10cm", Price = 160f, Description = "soft human hair wig", Image= "/Images/LongBlonde.jpg", ProductWDiscount = true, SupplierId = 2 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 4, Name = "Brown Wavy Wig", Colour = "Brown", Material = "Jane Human Hair", HairType = "Wavy", CapSize = "15cm", Price = 400f, Description = "Wavy wig with failry good hair volume for right fitting.", Image= "/Images/BrownHair.jpg", ProductWDiscount = false, SupplierId = 2 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 5, Name = "Full Wave Wig", Colour = "Black", Material = "Jane Human Hair", HairType = "Kinky", CapSize = "25cm", Price = 350f, Description = "This wig adds alot of brightness to one's look.", Image= "/Images/Kinky.jpg", ProductWDiscount = false, SupplierId = 1 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 6, Name = "Remy Human Hair", Colour = "Black", Material = "Jane Human Hair", HairType = "Curly", CapSize = "15cm", Price = 100f, Description = "Beautiful hair piece.", Image= "/Images/Curly.jpg", ProductWDiscount = true, SupplierId = 2 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 7, Name = "Remy Human Hair", Colour = "Blonde", Material = "Ronah Synthetic Hair", HairType = "Curly", CapSize = "15cm", Price = 100f, Description = "Beautiful hair piece.", Image= "/Images/Synthetic.jpg",ProductWDiscount = true, SupplierId = 1 });

            modelBuilder.Entity<Supplier>().HasData(new Supplier { SupplierId = 1, SupplierName = "Ronah Hair", Email = "ronahhair@gmail.com", PhoneNumber = "0401553313" });
            modelBuilder.Entity<Supplier>().HasData(new Supplier { SupplierId = 2, SupplierName = "Unique Hair Ltd", Email = "uniquehair@gmail.com", PhoneNumber = "0423000433" });
           
        }


    }
}
