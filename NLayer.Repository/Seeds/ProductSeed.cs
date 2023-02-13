using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id= 1,
                CategoryId= 1,
                Name="Kalem 1",
                Price = 100,
                Stock= 200,
                CreatedDate= DateTime.Now
            }, new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Kalem 2",
                Price = 50,
                Stock = 400,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Kalem 3",
                Price = 33,
                Stock = 430,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 4,
                CategoryId = 1,
                Name = "Kalem 4",
                Price = 90,
                Stock = 268,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 5,
                CategoryId = 2,
                Name = "Kitap 1",
                Price = 100,
                Stock = 150,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 6,
                CategoryId = 2,
                Name = "Kitap 2",
                Price = 120,
                Stock = 250,
                CreatedDate = DateTime.Now
            }
            );


        }
    }
}
