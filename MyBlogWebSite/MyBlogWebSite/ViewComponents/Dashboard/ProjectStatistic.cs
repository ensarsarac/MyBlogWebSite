using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Dashboard
{
    public class ProjectStatistic : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var values = c.Portfolios.ToList().Take(5);
            return View(values);
        }
    }
}
