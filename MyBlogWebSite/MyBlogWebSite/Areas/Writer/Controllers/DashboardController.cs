using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyBlogWebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            var values= await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = values.Name + " " + values.Surname;

            //weather
            /*https://api.openweathermap.org/data/2.5/weather?q=istanbul&appid=ea1d3710bfa202b90f422fb247baf29f */
            string key = "ea1d3710bfa202b90f422fb247baf29f";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + key;
            XDocument document = XDocument.Load(connection);
            ViewBag.v6 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //statistic
            Context c = new Context();
            ViewBag.v2 = c.WriterMessages.Where(x => x.Receiver == values.Email).Count();
            ViewBag.v3 = c.Announcements.Count();
            ViewBag.v4 = c.Users.Count();
            ViewBag.v5 = c.Skills.Count();

            return View();
        }
    }
}
