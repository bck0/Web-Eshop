using Faltynek.Eshop.Web.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faltynek.Eshop.Web.Models.Database
{
    public class EshopDbContext : DbContext
    {
        public DbSet<CarouselItem> CarouselItems { get; set; }
        public DbSet<Product> Product { get; set; }

        public EshopDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
