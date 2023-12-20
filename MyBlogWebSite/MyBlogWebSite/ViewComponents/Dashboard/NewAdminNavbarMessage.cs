using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.ViewComponents.Dashboard
{
    public class NewAdminNavbarMessage : ViewComponent
    {
        private readonly IWriterMessageService _writerMessage;

        public NewAdminNavbarMessage(IWriterMessageService writerMessage)
        {
            _writerMessage = writerMessage;
        }

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var values = _writerMessage.TGetList().OrderByDescending(x => x.Date).Take(5).ToList();
            return View(values);
        }
    }
}
