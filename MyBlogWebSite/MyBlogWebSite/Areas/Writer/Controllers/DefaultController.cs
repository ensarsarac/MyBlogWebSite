using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DefaultController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public DefaultController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {

            return View(_announcementService.TGetList());
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var values = _announcementService.TGetById(id);
            return View(values);
        }

    }
}
