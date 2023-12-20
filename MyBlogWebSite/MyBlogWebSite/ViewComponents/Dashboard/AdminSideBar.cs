using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Dashboard
{
    public class AdminSideBar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var user = c.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();
            ViewBag.userinfo = user.Name + " " + user.Surname;
            return View(user);
        }
    }
}
