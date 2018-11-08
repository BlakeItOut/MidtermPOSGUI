using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHS.Models
{
    public class InitialProductsData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GHSContext(
                serviceProvider.GetRequiredService<DbContextOptions<GHSContext>>()))
            {
                // Look for any movies.
                if (context.ProductModel.Any())
                {
                    return;   // DB has been seeded
                }

                context.ProductModel.AddRange(
                    new ProductModel
                    {
                        Name = "Chili",
                        Category = Category.snacker,
                        Description = "Snacker size of chili",
                        Price = 2.00
                    },
                    new ProductModel
                    {
                        Name = "Chili",
                        Category = Category.small,
                        Description = "Small size of chili",
                        Price = 5.00
                    },
                    new ProductModel
                    {
                        Name = "Chili",
                        Category = Category.medium,
                        Description = "Medium size of chili",
                        Price = 7.00
                    },
                    new ProductModel
                    {
                        Name = "Chili",
                        Category = Category.large,
                        Description = "Large size of chili",
                        Price = 12.00
                    },
                    new ProductModel
                    {
                        Name = "Potato Mushroom",
                        Category = Category.snacker,
                        Description = "Snacker size of Potato Mushroom",
                        Price = 2.00
                    },
                    new ProductModel
                    {
                        Name = "Potato Mushroom",
                        Category = Category.small,
                        Description = "Small size of Potato Mushroom",
                        Price = 5.00
                    },
                    new ProductModel
                    {
                        Name = "Potato Mushroom",
                        Category = Category.medium,
                        Description = "Medium size of Potato Mushroom",
                        Price = 7.00
                    },
                    new ProductModel
                    {
                        Name = "Potato Mushroom",
                        Category = Category.large,
                        Description = "Large size of Potato Mushroom",
                        Price = 12.00
                    },
                    new ProductModel
                    {
                        Name = "Garden Vegetable",
                        Category = Category.snacker,
                        Description = "Snacker size of Garden Vegetable",
                        Price = 2.00
                    },
                    new ProductModel
                    {
                        Name = "Garden Vegetable",
                        Category = Category.small,
                        Description = "Small size of Garden Vegetable",
                        Price = 5.00
                    },
                    new ProductModel
                    {
                        Name = "Garden Vegetable",
                        Category = Category.medium,
                        Description = "Medium size of Garden Vegetable",
                        Price = 7.00
                    },
                    new ProductModel
                    {
                        Name = "Garden Vegetable",
                        Category = Category.large,
                        Description = "Large size of Garden Vegetable",
                        Price = 12.00
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
