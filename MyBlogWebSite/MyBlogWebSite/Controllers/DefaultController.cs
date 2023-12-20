using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlogWebSite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptsPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            MessageManager mm = new MessageManager(new EfMessageRepository());
            SendMessageValidator validator = new SendMessageValidator();
            ValidationResult result = validator.Validate(message);

            if (result.IsValid)
            {
                message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                message.Status = true;
                mm.TAdd(message);
                var values = JsonConvert.SerializeObject(message);
                return Json(values);
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View("Index",message);

            }
        }

        [HttpGet]
        public PartialViewResult AddTestimonial()
        {
            return PartialView(new TestimonialViewModel());
        }

        [HttpPost]
        public IActionResult AddTestimonial(TestimonialViewModel p)
        {
            TestimonialManager tm = new TestimonialManager(new EfTestimonialRepository());
            Testimonial t = new Testimonial();

            if (p.ImageUrl != null)
            {
                var extension = Path.GetExtension(p.ImageUrl.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserImage/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageUrl.CopyTo(stream);
                t.ImageUrl = newImageName;
            }
            t.ClientName = p.ClientName;
            t.Comment = p.Comment;
            t.Company = p.Company;
            t.Status = false;
            tm.TAdd(t);
            return RedirectToAction("Index");
        }

    }
}
