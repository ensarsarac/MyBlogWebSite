using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Controllers
{
    public class AdminMessageController : Controller
    {
        private readonly IWriterMessageService _writerMessage;
        private readonly UserManager<AppUser> _userManager;

        public AdminMessageController(IWriterMessageService writerMessage, UserManager<AppUser> userManager)
        {
            _writerMessage = writerMessage;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _writerMessage.GetListByInbox(user.Email);
            return View(values);
        }
        public async Task<IActionResult> Sendbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _writerMessage.GetListBySendbox(user.Email);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = _writerMessage.TGetById(id);
            return View(value);
        }

        public IActionResult MessageDetailsSendbox(int id)
        {
            var value = _writerMessage.TGetById(id);
            return View(value);
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = _writerMessage.TGetById(id);
            _writerMessage.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateMessage()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMessage(WriterMessage p)
        {
            var senderUser = await _userManager.FindByNameAsync(User.Identity.Name);
            var receiverUser = await _userManager.FindByEmailAsync(p.Receiver);
            p.Sender = senderUser.Email;
            p.Date = DateTime.Now;
            p.ReceiverName = receiverUser.Name + " " + receiverUser.Surname;
            p.SenderName = senderUser.Name + " " + senderUser.Surname;
            _writerMessage.TAdd(p);
            return RedirectToAction("Index");
        }



    }
}
