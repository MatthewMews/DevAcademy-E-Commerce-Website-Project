﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PcParts.Data;

namespace PcParts.Migrations
{
    [DbContext(typeof(PcPartsContext))]
    [Migration("20181202121134_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PcParts.Data.Entities.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category_Name");

                    b.Property<int>("Product_Category_Id");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PcParts.Data.Entities.Graphics_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand_Name");

                    b.Property<string>("Key_Selling_Point");

                    b.Property<string>("Manufacturer_Name");

                    b.Property<string>("Model");

                    b.Property<decimal>("Monitor_Size");

                    b.Property<decimal>("Price");

                    b.Property<int?>("Product_Category_Idid");

                    b.Property<string>("Product_Description");

                    b.Property<string>("Product_Image");

                    b.HasKey("Id");

                    b.HasIndex("Product_Category_Idid");

                    b.ToTable("Graphics_Cards");
                });

            modelBuilder.Entity("PcParts.Data.Entities.Keyboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key_Selling_Point");

                    b.Property<string>("Manufacturer_Name");

                    b.Property<string>("Model");

                    b.Property<decimal>("Price");

                    b.Property<int?>("Product_Category_Idid");

                    b.Property<string>("Product_Description");

                    b.Property<string>("Product_Image");

                    b.HasKey("Id");

                    b.HasIndex("Product_Category_Idid");

                    b.ToTable("Keyboards");
                });

            modelBuilder.Entity("PcParts.Data.Entities.Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key_Selling_Point");

                    b.Property<string>("Manufacturer_Name");

                    b.Property<string>("Model");

                    b.Property<decimal>("Monitor_Size");

                    b.Property<decimal>("Price");

                    b.Property<int?>("Product_Category_Idid");

                    b.Property<string>("Product_Description");

                    b.Property<string>("Product_Image");

                    b.HasKey("Id");

                    b.HasIndex("Product_Category_Idid");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("PcParts.Data.Entities.Motherboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key_Selling_Point");

                    b.Property<string>("Manufacturer_Name");

                    b.Property<string>("Model");

                    b.Property<decimal>("Price");

                    b.Property<int?>("Product_Category_Idid");

                    b.Property<string>("Product_Description");

                    b.Property<string>("Product_Image");

                    b.HasKey("Id");

                    b.HasIndex("Product_Category_Idid");

                    b.ToTable("Motherboards");
                });

            modelBuilder.Entity("PcParts.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("OrderNumber");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new { Id = 1, OrderDate = new DateTime(2018, 12, 2, 12, 11, 34, 587, DateTimeKind.Utc), OrderNumber = "12345" }
                    );
                });

            modelBuilder.Entity("PcParts.Data.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderId");

                    b.Property<int?>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("PcParts.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductDescription");

                    b.Property<int>("ProductStock");

                    b.Property<string>("Size");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PcParts.Data.Entities.Graphics_Card", b =>
                {
                    b.HasOne("PcParts.Data.Entities.Category", "Product_Category_Id")
                        .WithMany()
                        .HasForeignKey("Product_Category_Idid");
                });

            modelBuilder.Entity("PcParts.Data.Entities.Keyboard", b =>
                {
                    b.HasOne("PcParts.Data.Entities.Category", "Product_Category_Id")
                        .WithMany()
                        .HasForeignKey("Product_Category_Idid");
                });

            modelBuilder.Entity("PcParts.Data.Entities.Monitor", b =>
                {
                    b.HasOne("PcParts.Data.Entities.Category", "Product_Category_Id")
                        .WithMany()
                        .HasForeignKey("Product_Category_Idid");
                });

            modelBuilder.Entity("PcParts.Data.Entities.Motherboard", b =>
                {
                    b.HasOne("PcParts.Data.Entities.Category", "Product_Category_Id")
                        .WithMany()
                        .HasForeignKey("Product_Category_Idid");
                });

            modelBuilder.Entity("PcParts.Data.Entities.OrderItem", b =>
                {
                    b.HasOne("PcParts.Data.Entities.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("PcParts.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
