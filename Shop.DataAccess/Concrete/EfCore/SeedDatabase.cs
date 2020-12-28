using Microsoft.EntityFrameworkCore;
using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
        }

        private static Category[] Categories = {
        new Category() {Id=1, Name = "Telefon" },
        new Category() {Id=2, Name= "Bilgisayar" }
        };
        private static Product[] Products = {
        new Product() {Id=1, Name = "Samsung S5", Price = 2000, ImageUrl="1.jpg" ,CategoryId=1 },
        new Product() {Id=2, Name = "Samsung S7", Price = 3000, ImageUrl="2.jpg",CategoryId=1 },
        new Product() {Id=3, Name = "Samsung S8", Price = 4000, ImageUrl="3.jpg",CategoryId=1 },
        new Product() {Id=4, Name = "Samsung S9", Price = 5200, ImageUrl="4.jpg",CategoryId=1 },
        new Product() {Id=5, Name = "IPhone 6", Price = 4200, ImageUrl="5.jpg",CategoryId=1 },
        new Product() {Id=6, Name = "IPhone 7", Price = 8000, ImageUrl="6.jpg",CategoryId=1 }
        };
    }
}
