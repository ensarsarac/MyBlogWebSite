using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Dashboard
{
    public class DashboardPortfolio : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            return View(c.Portfolios.ToList());
        }
    }
}
