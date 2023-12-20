using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Dashboard
{
    public class NewAdminNavbarAnnouncement :  ViewComponent
    {
        private readonly IAnnouncementService _announcementService;

        public NewAdminNavbarAnnouncement(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {

            return View(_announcementService.TGetList().OrderByDescending(x=>x.Date).Take(5).ToList());
        }
    }
}
