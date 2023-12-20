using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Controllers
{
    [Authorize(Roles = "Admin,Moderator")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View(_messageService.TGetList());
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetById(id);
            _messageService.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult MessageDetails(int id)
        {
            var value = _messageService.TGetById(id);
            return View(value);
        }



    }
}
