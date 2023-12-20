using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Controllers
{
    public class WriterController : Controller
    {
        private readonly UserManager<AppUser> _appUser;

        public WriterController(UserManager<AppUser> appUser)
        {
            _appUser = appUser;
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            var user= _appUser.FindByNameAsync(User.Identity.Name);
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {

            return PartialView();
        }

        public PartialViewResult SideBarPartial()
        {

            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {

            return PartialView();
        }


    }
}
