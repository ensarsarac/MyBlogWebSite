using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Controllers
{
    [Authorize(Roles ="Admin")]
    public class WritersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public WritersController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult GetUserList()
        {
            Context c = new Context();
            var values = JsonConvert.SerializeObject(c.Users.ToList());
            return Json(values);
        }

        public IActionResult GetById(int UserID)
        {
            Context c = new Context();
            var values = JsonConvert.SerializeObject(c.Users.Find(UserID));
            return Json(values);
        }
    }
}
