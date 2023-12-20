using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogWebSite.Areas.Writer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    [AllowAnonymous]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        

        [HttpGet]
        public IActionResult Index()
        {
            var value = new UserRegisterViewModel();
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser a = new AppUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Email,
                    UserName = p.UserName,
                    ImageUrl = p.Image
                };
                var result = await _userManager.CreateAsync(a, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }


            return View(p);
        }

    }
}
