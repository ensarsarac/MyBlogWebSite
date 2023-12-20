using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogWebSite.Areas.Writer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = value;
            ProfileViewModel model = new ProfileViewModel();
            model.Name = value.Name;
            model.Surname = value.Surname;
            model.UserName = value.UserName;
            model.Email = value.Email;
            return View(model);
        }


        [HttpPost]

        public async Task<IActionResult> Index(ProfileViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (p.Image!= null)
            {
                var extension = Path.GetExtension(p.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserImage/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.Image.CopyTo(stream);
                user.ImageUrl= newImageName;
            }
            if (ModelState.IsValid)
            {
                user.Name = p.Name;
                user.Surname = p.Surname;
                user.UserName = p.UserName;
                user.Email = p.Email;
                if (p.Password != null)
                {
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
                }
                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Default");
                }
                
            }
            

            return View();
        }


    }
}
