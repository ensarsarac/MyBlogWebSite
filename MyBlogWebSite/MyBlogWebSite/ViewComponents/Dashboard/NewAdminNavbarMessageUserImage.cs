using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Dashboard
{
    public class NewAdminNavbarMessageUserImage : ViewComponent
    {
        public IViewComponentResult Invoke(string mail)
        {
            Context c = new Context();
            var value = c.Users.Where(x => x.Email == mail).FirstOrDefault();
            return View(value);
        }
    }
}
