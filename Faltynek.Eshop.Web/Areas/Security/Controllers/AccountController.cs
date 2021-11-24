using Faltynek.Eshop.Web.Controllers;
using Faltynek.Eshop.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vogeltanz.Eshop.Web.Areas.Security.Controllers
{
    [Area("Security")]
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel registerVM)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""), new { area = "" });
            }

            return View(registerVM);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginVM)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction(nameof(HomeController.Index),nameof(HomeController).Replace("Controller",""), new { area = ""});
            }

            return View(loginVM);
        }

    }
}
