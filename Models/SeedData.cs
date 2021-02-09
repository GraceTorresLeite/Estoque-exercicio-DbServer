using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesProduct.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesProduct.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesProductContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesProductContext>>()))
            {
                //Look for any products
                if (context.Product.Any())
                {
                    return;
                }
                context.Product.AddRange(
                    new Product
                    {
                        Name = "Celular Samsung S10",
                        Price = 3000.00M,
                        Amount = 20
                    },

                    new Product
                    {
                        Name = "Celular Samsung S9",
                        Price = 2000.00M,
                        Amount = 10
                    },

                    new Product
                    {
                        Name = "Monitor Samsung 4K",
                        Price = 2000.00M,
                        Amount = 2
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
