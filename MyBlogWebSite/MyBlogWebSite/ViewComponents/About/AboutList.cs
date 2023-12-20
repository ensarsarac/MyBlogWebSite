using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        private readonly IAboutService _aboutService;
        

        public AboutList(IAboutService aboutService)
        {
            _aboutService = aboutService;
           
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetList().FirstOrDefault();
            return View(values);
        }
    }
}
