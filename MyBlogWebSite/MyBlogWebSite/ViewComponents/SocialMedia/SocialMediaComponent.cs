using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.SocialMedia
{
    public class SocialMediaComponent : ViewComponent
    {
        private readonly ISocialMediaService _socialMedia;

        public SocialMediaComponent(ISocialMediaService socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public IViewComponentResult Invoke()
        {

            return View(_socialMedia.TGetList());
        }
    }
}
