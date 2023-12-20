using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Writer
{
    public class NotificationComponent : ViewComponent
    {
        private readonly IAnnouncementService _manager;

        public NotificationComponent(IAnnouncementService manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _manager.TGetList().Where(x => x.Status == true).OrderByDescending(x => x.Date).Take(5).ToList();
            return View(values);
        }
    }
}
