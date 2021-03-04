﻿// <auto-generated />
using System;
using EssyWigs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EssyWigs.Migrations
{
    [DbContext(typeof(WigDbContext))]
    [Migration("20210303181655_EditedImagepath")]
    partial class EditedImagepath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EssyWigs.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductOrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductOrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("EssyWigs.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CapSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HairType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("ProductWDiscount")
                        .HasColumnType("bit");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CapSize = "15cm",
                            Colour = "Blonde",
                            Description = "Fluffy synthetic wig",
                            HairType = "Kinky",
                            Image = "/Images/BlondeHair.jpg",
                            Material = "Ronah Synthetic Hair",
                            Name = "Front Lace Wig",
                            Price = 200.0,
                            ProductWDiscount = true,
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CapSize = "20cm",
                            Colour = "Black",
                            Description = "Very soft human hair wig. Can be washed and styled.",
                            HairType = "Kinky",
                            Image = "/Images/Logo.jpg",
                            Material = "Jane Human Hair",
                            Name = "Lace Wig",
                            Price = 300.0,
                            ProductWDiscount = true,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CapSize = "10cm",
                            Colour = "Blonde",
                            Description = "soft human hair wig",
                            HairType = "Coily",
                            Image = "/Images/LongBlonde.jpg",
                            Material = "Jane Human Hair",
                            Name = "Beautiful Blonde Wavy",
                            Price = 160.0,
                            ProductWDiscount = true,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 4,
                            CapSize = "15cm",
                            Colour = "Brown",
                            Description = "Wavy wig with failry good hair volume for right fitting.",
                            HairType = "Wavy",
                            Image = "/Images/BrownHair.jpg",
                            Material = "Jane Human Hair",
                            Name = "Brown Wavy Wig",
                            Price = 400.0,
                            ProductWDiscount = false,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            CapSize = "25cm",
                            Colour = "Black",
                            Description = "This wig adds alot of brightness to one's look.",
                            HairType = "Kinky",
                            Image = "/Images/Kinky.jpg",
                            Material = "Jane Human Hair",
                            Name = "Full Wave Wig",
                            Price = 350.0,
                            ProductWDiscount = false,
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 6,
                            CapSize = "15cm",
                            Colour = "Black",
                            Description = "Beautiful hair piece.",
                            HairType = "Curly",
                            Image = "/Images/Curly.jpg",
                            Material = "Jane Human Hair",
                            Name = "Remy Human Hair",
                            Price = 100.0,
                            ProductWDiscount = true,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 7,
                            CapSize = "15cm",
                            Colour = "Blonde",
                            Description = "Beautiful hair piece.",
                            HairType = "Curly",
                            Image = "/Images/Synthetic.jpg",
                            Material = "Ronah Synthetic Hair",
                            Name = "Remy Human Hair",
                            Price = 100.0,
                            ProductWDiscount = true,
                            SupplierId = 1
                        });
                });

            modelBuilder.Entity("EssyWigs.Models.ProductOrder", b =>
                {
                    b.Property<int>("ProductOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("PaymentCardNo")
                        .HasColumnType("bigint");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductOrderPlaced")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductOrderId");

                    b.ToTable("ProductOrders");
                });

            modelBuilder.Entity("EssyWigs.Models.ShoppingCartProduct", b =>
                {
                    b.Property<int>("ShoppingCartProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartProducts");
                });

            modelBuilder.Entity("EssyWigs.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            Email = "ronahhair@gmail.com",
                            PhoneNumber = "0401553313",
                            SupplierName = "Ronah Hair"
                        },
                        new
                        {
                            SupplierId = 2,
                            Email = "uniquehair@gmail.com",
                            PhoneNumber = "0423000433",
                            SupplierName = "Unique Hair Ltd"
                        });
                });

            modelBuilder.Entity("EssyWigs.Models.OrderDetail", b =>
                {
                    b.HasOne("EssyWigs.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EssyWigs.Models.ProductOrder", "ProductOrder")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductOrder");
                });

            modelBuilder.Entity("EssyWigs.Models.Product", b =>
                {
                    b.HasOne("EssyWigs.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("EssyWigs.Models.ShoppingCartProduct", b =>
                {
                    b.HasOne("EssyWigs.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EssyWigs.Models.ProductOrder", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("EssyWigs.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
