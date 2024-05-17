using Microsoft.EntityFrameworkCore;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "Telefon", Url = "telefon" },
                new Category() { CategoryId = 2, Name = "Notebook", Url = "notebook" },
                new Category() { CategoryId = 3, Name = "Elektronic", Url = "elektronic" });

            builder.Entity<Product>().HasData(
            new Product() { ProductId = 1, Name = "IPhone 11", Url = "iphone-11", Price = 1500, ImageUrl = "1.jpg", Description = "Yaxwi telfondur", IsApproved = true },
            new Product() { ProductId = 2, Name = "IPhone 12 Pro", Url = "iphone-12", Price = 2000, ImageUrl = "2.jpg", Description = "Yaxwi telfondur", IsApproved = true },
            new Product() { ProductId = 3, Name = "IPhone 13", Url = "iphone-13", Price = 2500, ImageUrl = "3.jpg", Description = "Yaxwi telfondur", IsApproved = true },
            new Product() { ProductId = 4, Name = "IPhone 14 Max", Url = "iphone-14", Price = 3000, ImageUrl = "4.jpg", Description = "Yaxwi telfondur", IsApproved = false },
            new Product() { ProductId = 5, Name = "IPhone 15", Url = "iphone-15", Price = 3500, ImageUrl = "5.jpg", Description = "Yaxwi telfondur", IsApproved = true });


            builder.Entity<ProductCategory>().HasData(
               new ProductCategory() { ProductId = 1, CategoryId = 1 },
               new ProductCategory() { ProductId = 1, CategoryId = 3 },
               new ProductCategory() { ProductId = 2, CategoryId = 1 },
               new ProductCategory() { ProductId = 2, CategoryId = 3 },
               new ProductCategory() { ProductId = 3, CategoryId = 3 },
               new ProductCategory() { ProductId = 4, CategoryId = 2 },
               new ProductCategory() { ProductId = 4, CategoryId = 3 },
               new ProductCategory() { ProductId = 5, CategoryId = 3 },
               new ProductCategory() { ProductId = 5, CategoryId = 1 }
               );
        }
    }
}
