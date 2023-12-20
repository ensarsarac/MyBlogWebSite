using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        private readonly IContactService _contactService;

        public ContactDetails(IContactService contactService)
        {
            _contactService = contactService;
        }


        public IViewComponentResult Invoke()
        {
            var values = _contactService.TGetList().Where(x => x.Status == true).FirstOrDefault();
            return View(values);
        }
    }
}
