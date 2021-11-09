using Faltynek.Eshop.Web.Models;
using Faltynek.Eshop.Web.Models.Database;
using Faltynek.Eshop.Web.Models.Entity;
using Faltynek.Eshop.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Faltynek.Eshop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EshopDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, EshopDbContext dbContext)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IndexViewModel indexVM = new IndexViewModel();
            indexVM.CarouselItems = _dbContext.CarouselItems.ToList();
            indexVM.Products = _dbContext.Product.ToList();
            return View(indexVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
