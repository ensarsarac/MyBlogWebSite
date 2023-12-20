using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlogWebSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Controllers
{
    [Authorize(Roles = "Admin,Moderator")]
    public class TestimonialController : Controller
    {
        
        TestimonialManager tm = new TestimonialManager(new EfTestimonialRepository());
        public IActionResult Index()
        {
            return View(tm.TGetList());
        }

        public IActionResult Delete(int id)
        {
            var value = tm.TGetById(id);
            tm.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = tm.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Testimonial p)
        {
            tm.TUpdate(p);
            return RedirectToAction("Index");
        }

       



}
}
