﻿// <auto-generated />
using System;
using AlamoCorp.Web.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlamoCorp.Web.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190910160737_ModelModif")]
    partial class ModelModif
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlamoCorp.Web.Core.Models.Core.Address", b =>
                {
                    b.Property<long>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("PostCode");

                    b.Property<string>("SecondStreetName");

                    b.Property<string>("State");

                    b.Property<string>("StreetName");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AlamoCorp.Web.Core.Models.Core.Customer", b =>
                {
                    b.Property<long>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("BillingAddressAddressID");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<long?>("ShippingAddressAddressID");

                    b.HasKey("CustomerID");

                    b.HasIndex("BillingAddressAddressID");

                    b.HasIndex("ShippingAddressAddressID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AlamoCorp.Web.Core.Models.Core.Order", b =>
                {
                    b.Property<long>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long?>("CustomerID");

                    b.Property<int>("DeliveryMethod");

                    b.Property<int>("DeliveryStatus");

                    b.Property<int>("PaymentMethod");

                    b.Property<decimal>("TotalAmount");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AlamoCorp.Web.Core.Models.Core.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("MainImageURL");

                    b.Property<string>("Name");

                    b.Property<long?>("OrderID");

                    b.Property<decimal>("Price");

                    b.HasKey("ProductID");

                    b.HasIndex("OrderID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AlamoCorp.Web.Core.Models.Core.Customer", b =>
                {
                    b.HasOne("AlamoCorp.Web.Core.Models.Core.Address", "BillingAddress")
                        .WithMany()
                        .HasForeignKey("BillingAddressAddressID");

                    b.HasOne("AlamoCorp.Web.Core.Models.Core.Address", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressAddressID");
                });

            modelBuilder.Entity("AlamoCorp.Web.Core.Models.Core.Order", b =>
                {
                    b.HasOne("AlamoCorp.Web.Core.Models.Core.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");
                });

            modelBuilder.Entity("AlamoCorp.Web.Core.Models.Core.Product", b =>
                {
                    b.HasOne("AlamoCorp.Web.Core.Models.Core.Order")
                        .WithMany("LineItems")
                        .HasForeignKey("OrderID");
                });
#pragma warning restore 612, 618
        }
    }
}
