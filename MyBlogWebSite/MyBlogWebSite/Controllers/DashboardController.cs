using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MyBlogWebSite.Controllers
{
    [Authorize(Roles = "Admin,Moderator")]
    public class DashboardController : Controller
    {        
        
        
        public IActionResult Index(int p=1)
        {
            Context c = new Context();
            ViewBag.v1 = c.Portfolios.Count();
            return View(c.Portfolios.ToPagedList(p,4));
        }
    }
}
