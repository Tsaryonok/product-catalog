﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductCatalog.DataAccess.Context;

#nullable disable

namespace ProductCatalog.DataAccess.Migrations
{
    [DbContext(typeof(ProductCatalogContext))]
    partial class ProductCatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProductCatalog.DataAccess.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("ProductCatalog.DataAccess.Entities.Currency", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("code");

                    b.Property<int>("MinorUnits")
                        .HasColumnType("int")
                        .HasColumnName("minor_units");

                    b.HasKey("Id");

                    b.ToTable("currencies", (string)null);
                });

            modelBuilder.Entity("ProductCatalog.DataAccess.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("CommonNote")
                        .HasColumnType("longtext")
                        .HasColumnName("common_note");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("cost");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("SpecialNote")
                        .HasColumnType("longtext")
                        .HasColumnName("special_note");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("ProductCatalog.DataAccess.Entities.Product", b =>
                {
                    b.HasOne("ProductCatalog.DataAccess.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ProductCatalog.DataAccess.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
