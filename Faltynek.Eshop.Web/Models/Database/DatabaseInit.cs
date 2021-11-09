using Faltynek.Eshop.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faltynek.Eshop.Web.Models.Database
{
    public class DatabaseInit
    {
        public void Initialize(EshopDbContext eshopDbContext)
        {
            eshopDbContext.Database.EnsureCreated();

            if(eshopDbContext.CarouselItems.Count() == 0)
            {
                IList<CarouselItem> carouselItems = GenerateCarouselItems();
                foreach(var ci in carouselItems)
                {
                    eshopDbContext.CarouselItems.Add(ci);
                }
                eshopDbContext.SaveChanges();
            }

            if (eshopDbContext.Product.Count() == 0)
            {
                IList<Product> products = GenerateProductItems();
                foreach (var pi in products)
                {
                    eshopDbContext.Product.Add(pi);
                }
                eshopDbContext.SaveChanges();
            }
        }
        public List<CarouselItem> GenerateCarouselItems()
        {
            List<CarouselItem> carouselItems = new List<CarouselItem> { };

            CarouselItem ci1 = new CarouselItem()
            {
                ID = 0,
                ImageSource = "/img/jirik3.jpg",
                ImageAlt = "First slide"
            };
            CarouselItem ci2 = new CarouselItem()
            {
                ID = 1,
                ImageSource = "/img/jirik.jpg",
                ImageAlt = "Second slide"
            };
            CarouselItem ci3 = new CarouselItem()
            {
                ID = 2,
                ImageSource = "/img/jirik2.jpg",
                ImageAlt = "Third slide"
            };

            carouselItems.Add(ci1);
            carouselItems.Add(ci2);
            carouselItems.Add(ci3);

            return carouselItems;

        }

        public List<Product> GenerateProductItems()
        {
            List<Product> products = new List<Product> { };

            Product p1 = new Product()
            {
                ID = 0,
                ImageSource = "/img/jirik3.jpg",
                ImageAlt = "PS"
            };
            Product p2 = new Product()
            {
                ID = 1,
                ImageSource = "/img/jirik3.jpg",
                ImageAlt = "PC"
            };
            Product p3 = new Product()
            {
                ID = 2,
                ImageSource = "/img/jirik3.jpg",
                ImageAlt = "iPhone"
            };

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            return products;
        }
    }
}
