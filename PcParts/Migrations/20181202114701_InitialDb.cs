using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PcParts.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category_Name = table.Column<string>(nullable: true),
                    Product_Category_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ProductStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Graphics_Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Category_Idid = table.Column<int>(nullable: true),
                    Monitor_Size = table.Column<decimal>(nullable: false),
                    Manufacturer_Name = table.Column<string>(nullable: true),
                    Brand_Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Product_Description = table.Column<string>(nullable: true),
                    Key_Selling_Point = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Product_Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Graphics_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Graphics_Cards_Categories_Product_Category_Idid",
                        column: x => x.Product_Category_Idid,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Keyboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Category_Idid = table.Column<int>(nullable: true),
                    Manufacturer_Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Product_Description = table.Column<string>(nullable: true),
                    Key_Selling_Point = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Product_Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Keyboards_Categories_Product_Category_Idid",
                        column: x => x.Product_Category_Idid,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Category_Idid = table.Column<int>(nullable: true),
                    Monitor_Size = table.Column<decimal>(nullable: false),
                    Manufacturer_Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Product_Description = table.Column<string>(nullable: true),
                    Key_Selling_Point = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Product_Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitors_Categories_Product_Category_Idid",
                        column: x => x.Product_Category_Idid,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Category_Idid = table.Column<int>(nullable: true),
                    Manufacturer_Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Product_Description = table.Column<string>(nullable: true),
                    Key_Selling_Point = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Product_Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motherboards_Categories_Product_Category_Idid",
                        column: x => x.Product_Category_Idid,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Graphics_Cards_Product_Category_Idid",
                table: "Graphics_Cards",
                column: "Product_Category_Idid");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_Product_Category_Idid",
                table: "Keyboards",
                column: "Product_Category_Idid");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_Product_Category_Idid",
                table: "Monitors",
                column: "Product_Category_Idid");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboards_Product_Category_Idid",
                table: "Motherboards",
                column: "Product_Category_Idid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Graphics_Cards");

            migrationBuilder.DropTable(
                name: "Keyboards");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
