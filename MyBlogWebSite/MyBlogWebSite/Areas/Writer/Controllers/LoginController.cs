using DataAccessLayer.Concrete;
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


    //[Authorize] // sayfaları kısıtlar mesela login sayfası görünmez. rollerle devam edicez.
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

    
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                var values = await _signInManager.PasswordSignInAsync(model.Username, model.Password,true,true);

                if (values.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard",new {area ="Writer" });
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                }
            }
            return View(model);
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Default", new { @area = "" });
        }
    }
}
