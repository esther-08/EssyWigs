using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EssyWigs.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ShoppingCarts_ShoppingCartId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stakeholders",
                table: "Stakeholders");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Stakeholders");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Stakeholders");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Stakeholders");

            migrationBuilder.DropColumn(
                name: "PaymentCardNo",
                table: "Stakeholders");

            migrationBuilder.RenameTable(
                name: "Stakeholders",
                newName: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "Products",
                newName: "SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ShoppingCartId",
                table: "Products",
                newName: "IX_Products_SupplierId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Suppliers",
                newName: "SupplierId");

            migrationBuilder.AddColumn<bool>(
                name: "ProductWDiscount",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "SupplierId");

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    ProductOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentCardNo = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductOrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => x.ProductOrderId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartProducts",
                columns: table => new
                {
                    ShoppingCartProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    TotalCost = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartProducts", x => x.ShoppingCartProductId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductOrderId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ProductOrders_ProductOrderId",
                        column: x => x.ProductOrderId,
                        principalTable: "ProductOrders",
                        principalColumn: "ProductOrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Email", "PhoneNumber", "SupplierName" },
                values: new object[] { 1, "ronahhair@gmail.com", "0401553313", "Ronah Hair" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Email", "PhoneNumber", "SupplierName" },
                values: new object[] { 2, "uniquehair@gmail.com", "0423000433", "Unique Hair Ltd" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CapSize", "Colour", "Description", "Material", "Name", "Price", "ProductWDiscount", "SupplierId" },
                values: new object[] { "15cm", "Maroon", "Fluffy synthetic wig", "Ronah Synthetic Hair", "Front Lace Wig", 200.0, true, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CapSize", "Colour", "Description", "Material", "Name", "Price", "ProductWDiscount", "SupplierId" },
                values: new object[] { "20cm", "Black", "Very soft human hair wig. Can be washed and styled.", "Jane Human Hair", "Lace Wig", 300.0, true, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CapSize", "Colour", "Description", "HairType", "Material", "Name", "Price", "ProductWDiscount", "SupplierId" },
                values: new object[,]
                {
                    { 5, "25cm", "Gold", "This wig adds alot of brightness to one's look.", "Kinky", "Jane Human Hair", "Full Wave Wig", 350.0, false, 1 },
                    { 7, "15cm", "Gold", "Beautiful hair piece.", "Curly", "Ronah Synthetic Hair", "Remy Human Hair", 100.0, true, 1 },
                    { 3, "10cm", "Blonde", "soft human hair wig", "Coily", "Jane Human Hair", "Beautiful Blonde Wavy", 160.0, true, 2 },
                    { 4, "15cm", "Brown", "Wavy wig with failry good hair volume for right fitting.", "Wavy", "Jane Human Hair", "Brown Wavy Wig", 400.0, false, 2 },
                    { 6, "15cm", "Gold", "Beautiful hair piece.", "Curly", "Jane Human Hair", "Remy Human Hair", 100.0, true, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductOrderId",
                table: "OrderDetails",
                column: "ProductOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartProducts_ProductId",
                table: "ShoppingCartProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartProducts");

            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ProductWDiscount",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Stakeholders");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Products",
                newName: "ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                newName: "IX_Products_ShoppingCartId");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Stakeholders",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Stakeholders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Stakeholders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Stakeholders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PaymentCardNo",
                table: "Stakeholders",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stakeholders",
                table: "Stakeholders",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    TotalCost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ShoppingCartId);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Stakeholders_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Stakeholders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CapSize", "Colour", "Description", "Material", "Name", "Price", "ShoppingCartId" },
                values: new object[] { "20cm", "Black", "Very soft human hair wig", "Jane Human Hair", "Lace Wig", 300.0, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CapSize", "Colour", "Description", "Material", "Name", "Price", "ShoppingCartId" },
                values: new object[] { "15cm", "Maroon", "FLuffy synthetic wig", "Jane Synthetic Hair", "Front Lace Wig", 200.0, null });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_CustomerId",
                table: "ShoppingCarts",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ShoppingCarts_ShoppingCartId",
                table: "Products",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "ShoppingCartId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
