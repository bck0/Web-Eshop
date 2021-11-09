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
                ImageSource = "/img/ps5.jpg",
                ImageAlt = "Playstation 5",
                Price = 999,
                Info = "Konzole zvládne rozlišení až 4K, v případě videí a jednodušších her až 8K. Výchozí SSD úložiště s 825 GB by mělo pracovat vysokou rychlostí 5,5 GB/s, propojené je rozhraním NVMe. ... PS5 je zpětně kompatibilní s hrami z PS4. Proměnlivý hrací režim spotřebuje výrazně méně energie než u PS4."
            };
            Product p2 = new Product()
            {
                ID = 1,
                ImageSource = "/img/pc.jpg",
                ImageAlt = "Počítač",
                Price = 1500,
                Info = "PC BARBONE GAME r5 1660 Ti - AMD Ryzen 5 3600, operační paměť 16GB DDR4 3200MHz, 500GB NVMe SSD, grafická karta GTX 1660 Ti 6GB, WiFi, Windows 10 Home"
            };
            Product p3 = new Product()
            {
                ID = 2,
                ImageSource = "/img/iphone.jpg",
                ImageAlt = "iPhone 13 128Gb",
                Price = 1200,
                Info = "Mobilní telefon - 6,1 Super Retina XDR 2532 × 1170, procesor Apple A15 Bionic 6jádrový, RAM 6 GB, interní paměť 128 GB, zadní fotoaparát 12 Mpx (f/1,6) + 12 Mpx (f/2,4), přední fotoaparát 12 Mpx, GPS, Glonass, NFC, LTE, 5G, Lightning, iOS"
            };

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            return products;
        }
    }
}
