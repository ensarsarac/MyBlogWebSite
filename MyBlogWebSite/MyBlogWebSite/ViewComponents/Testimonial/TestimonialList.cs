using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using MyBlogWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;
        TestimonialTwoModel model = new TestimonialTwoModel();
        public TestimonialList(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            
            return View(_testimonialService.TGetList().Where(x => x.Status == true).Take(3).ToList());
        }

    }
}
