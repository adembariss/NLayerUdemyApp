﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayer.Repository;

#nullable disable

namespace NLayer.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NLayer.Core.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kalemler"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kitaplar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Defterler"
                        });
                });

            modelBuilder.Entity("NLayer.Core.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 2, 9, 11, 21, 21, 166, DateTimeKind.Local).AddTicks(2527),
                            Name = "Kalem 1",
                            Price = 100m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 2, 9, 11, 21, 21, 166, DateTimeKind.Local).AddTicks(2538),
                            Name = "Kalem 2",
                            Price = 50m,
                            Stock = 400
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 2, 9, 11, 21, 21, 166, DateTimeKind.Local).AddTicks(2538),
                            Name = "Kalem 3",
                            Price = 33m,
                            Stock = 430
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 2, 9, 11, 21, 21, 166, DateTimeKind.Local).AddTicks(2539),
                            Name = "Kalem 4",
                            Price = 90m,
                            Stock = 268
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2023, 2, 9, 11, 21, 21, 166, DateTimeKind.Local).AddTicks(2540),
                            Name = "Kitap 1",
                            Price = 100m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2023, 2, 9, 11, 21, 21, 166, DateTimeKind.Local).AddTicks(2541),
                            Name = "Kitap 2",
                            Price = 120m,
                            Stock = 250
                        });
                });

            modelBuilder.Entity("NLayer.Core.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Kırmızı",
                            Height = 50,
                            ProductId = 1,
                            Width = 100
                        },
                        new
                        {
                            Id = 2,
                            Color = "Sarı",
                            Height = 150,
                            ProductId = 2,
                            Width = 160
                        });
                });

            modelBuilder.Entity("NLayer.Core.Product", b =>
                {
                    b.HasOne("NLayer.Core.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NLayer.Core.ProductFeature", b =>
                {
                    b.HasOne("NLayer.Core.Product", "Product")
                        .WithOne("ProductFeature")
                        .HasForeignKey("NLayer.Core.ProductFeature", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NLayer.Core.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NLayer.Core.Product", b =>
                {
                    b.Navigation("ProductFeature")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
