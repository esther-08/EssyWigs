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
    [Migration("20210220160250_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 2,
                            CapSize = "15cm",
                            Colour = "Maroon",
                            Description = "FLuffy synthetic wig",
                            HairType = "Kinky",
                            Material = "Jane Synthetic Hair",
                            Name = "Front Lace Wig",
                            Price = 200.0
                        },
                        new
                        {
                            ProductId = 1,
                            CapSize = "20cm",
                            Colour = "Black",
                            Description = "Very soft human hair wig",
                            HairType = "Kinky",
                            Material = "Jane Human Hair",
                            Name = "Lace Wig",
                            Price = 300.0
                        });
                });

            modelBuilder.Entity("EssyWigs.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("CustomerId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("EssyWigs.Models.Stakeholder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stakeholders");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Stakeholder");
                });

            modelBuilder.Entity("EssyWigs.Models.Customer", b =>
                {
                    b.HasBaseType("EssyWigs.Models.Stakeholder");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PaymentCardNo")
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("EssyWigs.Models.Supplier", b =>
                {
                    b.HasBaseType("EssyWigs.Models.Stakeholder");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Supplier");
                });

            modelBuilder.Entity("EssyWigs.Models.Product", b =>
                {
                    b.HasOne("EssyWigs.Models.ShoppingCart", null)
                        .WithMany("Products")
                        .HasForeignKey("ShoppingCartId");
                });

            modelBuilder.Entity("EssyWigs.Models.ShoppingCart", b =>
                {
                    b.HasOne("EssyWigs.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("EssyWigs.Models.ShoppingCart", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
