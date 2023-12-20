using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Footer
{
    public class FooterDetails : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
