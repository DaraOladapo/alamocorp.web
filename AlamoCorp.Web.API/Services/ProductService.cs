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
                    Name="Ale Grafted Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-01.png",
                    Price=7350,
                    DateCreated=DateTime.Now
                },
                  new Product()
                {
                    Name="Black Tea Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-02.png",
                    Price=2500,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Owl Mug",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-03.png",
                    Price=3125,
                    DateCreated=DateTime.Now
                }, new Product()
                {
                    Name="Alamo White Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-04.png",
                    Price=2450,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Starbuck Fav",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-05.png",
                    Price=3280,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Abstract Swipe Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-06.png",
                    Price=1300,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Vintage Paris Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-07.png",
                    Price=2500,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Plain Black Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-08.png",
                    Price=3000,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Flowery Pair Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-09.png",
                    Price=1500,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Plasted Love Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-10.png",
                    Price=2000,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="White Saucer",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-11.png",
                    Price=1200,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Stylized White Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-12.png",
                    Price=3050,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Moto Espresso Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-13.png",
                    Price=4000,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Crooked Yellow Mug",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-14.png",
                    Price=1200,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Homely Set",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-15.png",
                    Price=13000,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Chinese Vintage Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-16.png",
                    Price=2390,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Vintage Coffee Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-17.png",
                    Price=7000,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Baked Brown Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-18.png",
                    Price=500,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="6-set Blue Stack Set",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-19.png",
                    Price=1500,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Fine Saucer",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-20.png",
                    Price=3200,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Gummy-Buddy Ale Mug",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-21.png",
                    Price=1430,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Winely Craft Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-22.png",
                    Price=3000,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="another White One",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-23.png",
                    Price=1235,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="Classic Yellow Mug",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-24.png",
                    Price=3230,
                    DateCreated=DateTime.Now
                },  new Product()
                {
                    Name="3-in-1 Sauce Cup",
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus tristique vestibulum nisl non consequat. Curabitur consequat vel enim eget feugiat. Phasellus scelerisque mauris nec finibus. ",
                    MainImageURL="https://azmigday.blob.core.windows.net/images/alamocup-25.png",
                    Price=4000,
                    DateCreated=DateTime.Now
                }
            };
            dbContext.Products.AddRange(Products);
            dbContext.SaveChanges();
        }
        internal static IEnumerable<Product> AddProduct(ApplicationDbContext dbContext, Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();

            var Products = dbContext.Products.ToList();
            return Products;
        }
    }
}
