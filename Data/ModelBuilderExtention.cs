using bakaryshop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakaryshop.Data
{
    public static class ModelBuilderExtention
    {
        public static  ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            Product[] products = {
                new Product
                {
                id = 1,
                product_name = "carrot cake",
                description = "carrot cake any description",
                imagename = "carrot-cake-1200x800"
                },
                new Product
                {
                id = 2,
                product_name = "cup cake",
                description = "cup cake any description",
                imagename = "cup cake.jpg"
                },
                 new Product
                {
                id = 3,
                product_name = "choclate cake",
                description = "choclate cake any description",
                imagename = "choclate cake.jpg"
                },
                  new Product
                {
                id = 4,
                product_name = "Lemon-cake",
                description = "Lemon-cake any description",
                imagename = "Lemon-cake.jpg"
                },
            };
            modelBuilder.Entity<Product>().HasData(products);
            return modelBuilder;
        }
    }
    
}
