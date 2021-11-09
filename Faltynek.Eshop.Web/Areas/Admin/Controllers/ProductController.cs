using Faltynek.Eshop.Web.Models.Database;
using Faltynek.Eshop.Web.Models.Entity;
using Faltynek.Eshop.Web.Models.Implementation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faltynek.Eshop.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        readonly EshopDbContext eshopDbContext;
        IWebHostEnvironment env;
        public ProductController(EshopDbContext eshopDB, IWebHostEnvironment env)
        {
            eshopDbContext = eshopDB;
            this.env = env;
        }
        public IActionResult Select()
        {
            IList<Product> productItems = eshopDbContext.Product.ToList();
            return View(productItems);

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product productItem)
        {
            if (productItem != null && productItem.Image != null)
            {
                FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/ProductItems", "image");
                productItem.ImageSource = await fileUpload.FileUploadAsync(productItem.Image);

                if (String.IsNullOrWhiteSpace(productItem.ImageSource) == false)
                {

                    eshopDbContext.Product.Add(productItem);
                    await eshopDbContext.SaveChangesAsync();

                    return RedirectToAction(nameof(ProductController.Select));

                }

            }
  
                return View(productItem);
            

        }

        public IActionResult Edit(int ID)
        {
            Product pFromDatabase = DatabaseFake.ProductItems.FirstOrDefault(ci => ci.ID == ID);
            if (pFromDatabase != null)
            {
                return View(pFromDatabase);

            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product productItem)
        {
            Product pFromDatabase = DatabaseFake.ProductItems.FirstOrDefault(ci => ci.ID == productItem.ID);
            if (pFromDatabase != null)
            {
                if (productItem != null && productItem.Image != null)
                {
                    FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/ProductItems", "image");
                    productItem.ImageSource = await fileUpload.FileUploadAsync(productItem.Image);

                    if (String.IsNullOrWhiteSpace(productItem.ImageSource) == false)
                    {


                        pFromDatabase.ImageSource = productItem.ImageSource;
                    }
                }
                pFromDatabase.ImageAlt = productItem.ImageAlt;

                await eshopDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(ProductController.Select));
            }
            else
            {
                return NotFound();
            }

        }
        public async Task<IActionResult> Delete(int ID)
        {
            DbSet<Product> productItems = eshopDbContext.Product;

            Product productItem = productItems.Where(productItem => productItem.ID == ID).FirstOrDefault();

            if (productItem != null)
            {
                productItems.Remove(productItem);
                await eshopDbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(ProductController.Select));
        }

    }
}
