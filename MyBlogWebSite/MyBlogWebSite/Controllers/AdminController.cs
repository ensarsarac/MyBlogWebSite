using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult AdminFooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminHeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminScriptPartial()
        {
            return PartialView();
        }

        public PartialViewResult AdminSideBar()
        {
            return PartialView();
        }





    }
}
