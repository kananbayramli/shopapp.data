﻿using Microsoft.EntityFrameworkCore;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed() 
        {
            // var context = new ShopContext();

            // if (context.Database.GetPendingMigrations().Count() == 0) 
            // {
            //     if (context.Categories.Count() == 0) 
            //     {
            //         context.Categories.AddRange(Categories);
            //     }

            //     if (context.Products.Count() == 0)
            //     {
            //         context.Products.AddRange(Products);
            //         context.AddRange(ProductCategories);
            //     }
            // }

            // context.SaveChanges();
        }

        private static Category[] Categories = {
            new Category(){ Name = "Telefon", Url="telefon"},
            new Category(){ Name = "Notebook", Url="notebook"},
            new Category(){ Name = "Elektronic", Url="elektronic"}
        };

        //url unique olmalidir
        private static Product[] Products = {
            new Product(){ Name = "IPhone 11", Url="iphone-11", Price=1500,ImageUrl="1.jpg", Description="Yaxwi telfondur", IsApproved=true},
            new Product(){ Name = "IPhone 12 Pro", Url="iphone-12", Price=2000,ImageUrl="2.jpg", Description="Yaxwi telfondur", IsApproved=true},
            new Product(){ Name = "IPhone 13", Url="iphone-13", Price=2500,ImageUrl="3.jpg", Description="Yaxwi telfondur", IsApproved=true},
            new Product(){ Name = "IPhone 14 Max", Url="iphone-14", Price=3000,ImageUrl="4.jpg", Description="Yaxwi telfondur", IsApproved=false},
            new Product(){ Name = "IPhone 15", Url="iphone-15", Price=3500,ImageUrl="5.jpg", Description="Yaxwi telfondur", IsApproved=true}
        };

        private static ProductCategory[] ProductCategories = {
            new ProductCategory(){ Product=Products[0], Category=Categories[0]},
            new ProductCategory(){ Product=Products[0], Category=Categories[2]},
            new ProductCategory(){ Product=Products[1], Category=Categories[0]},
            new ProductCategory(){ Product=Products[1], Category=Categories[2]},
            new ProductCategory(){ Product=Products[2], Category=Categories[0]},
            new ProductCategory(){ Product=Products[2], Category=Categories[2]},
            new ProductCategory(){ Product=Products[3], Category=Categories[0]},
            new ProductCategory(){ Product=Products[3], Category=Categories[2]}
        };
    }
}
