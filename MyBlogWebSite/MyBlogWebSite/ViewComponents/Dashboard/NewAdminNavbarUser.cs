using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Dashboard
{
    public class NewAdminNavbarUser :  ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public NewAdminNavbarUser(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value =await _userManager.FindByNameAsync(User.Identity.Name);
            return View(value);
        }
    }
}
