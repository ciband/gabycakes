using GabyCakes.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GabyCakes.API.Data
{
    public static class DBInitializer
    {
        public static List<Product> Initialize()
        {
            return new List<Product>
            {
                new Product {
                    Id = 1,
                    Category = Category.Cupcakes,
                    Title = "Chocolate Cupcake",
                    Description = "Tastes Good",
                    ImagePath = "",
                    Price = 2.0M
                },
                new Product {
                    Id = 2,
                    Category = Category.Cupcakes,
                    Title = "Vanilla Cupcake",
                    Description = "Tastes Good",
                    ImagePath = "",
                    Price = 2.0M
                }
            };
        }
    }
}
