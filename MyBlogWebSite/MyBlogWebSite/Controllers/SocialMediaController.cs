using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Controllers
{
    [Authorize(Roles = "Admin,Moderator")]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMedia;

        public SocialMediaController(ISocialMediaService socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public IActionResult Index()
        {

            return View(_socialMedia.TGetList());
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            p.Status = true;
            _socialMedia.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {

            var value = _socialMedia.TGetById(id);
            _socialMedia.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            return View(_socialMedia.TGetById(id));
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia p)
        {
            _socialMedia.TUpdate(p);
            return RedirectToAction("Index");
        }




    }
}
