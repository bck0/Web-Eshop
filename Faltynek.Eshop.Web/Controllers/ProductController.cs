using Faltynek.Eshop.Web.Models.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faltynek.Eshop.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly EshopDbContext _dbContext;

        public ProductController(EshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Detail(int ID)
        {
            var model = _dbContext.Product.Where(productItem => productItem.ID == ID).FirstOrDefault();
            return View(model);
        }
    }
}
