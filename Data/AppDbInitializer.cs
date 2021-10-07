using JoesPizza.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoesPizza.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Products
                if (!context.Products.Any()) 
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = " Hot Chicken",
                            Description = "This is Description for first product",
                            Price = 159.99,
                            ImageURL = "https://dbqmd35foa1f5.cloudfront.net/2018/07/02/New-Menu-Image-Hot-Chicken-Pizza.jpg",
                            Diet = Diet.Vegan
                        },
                        new Product()
                        {
                            Name = " Ultimate 4 Cheese",
                            Description = "This is Description for second product",
                            Price = 79.99,
                            ImageURL = "https://dbqmd35foa1f5.cloudfront.net/2020/05/27/Ultimate-Four-Cheese.jpg",
                            Diet = Diet.Pescatarian
                        },
                        new Product()
                        {
                            Name = " Margherita",
                            Description = "This is Description for 3rd product",
                            Price = 169.95,
                            ImageURL = "https://dbqmd35foa1f5.cloudfront.net/2018/07/02/New-Menu-Image-Margherita-Core.jpg",
                            Diet = Diet.Flexitarian
                        },
                        new Product()
                        {
                            Name = " Very Vegy",
                            Description = "This is Description for 4th product",
                            Price = 99.99,
                            ImageURL = "https://dbqmd35foa1f5.cloudfront.net/2018/07/02/New-Menu-Image-Very-Vegy.jpg",
                           Diet = Diet.Vegetarian
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
