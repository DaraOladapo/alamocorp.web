using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlamoCorp.Web.API.Data;
using AlamoCorp.Web.Core.Models.Core;

namespace AlamoCorp.Web.API.Services
{
    public class ProductService
    {
        internal static void SeedProducts(ApplicationDbContext dbContext)
        {
            var Products = new List<Product>()
            {
                new Product()
                {
                    Name="Gold Ceramic Cup",
                     Description="",
                      MainImageURL="",
                       Price=3500,
                     DateCreated=DateTime.Now,

                }
            };
            dbContext.Products.AddRange(Products);
            dbContext.SaveChanges();
        }
    }
}
