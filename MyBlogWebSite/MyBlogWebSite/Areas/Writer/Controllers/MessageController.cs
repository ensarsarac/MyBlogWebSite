using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        private readonly IWriterMessageService _writerMessage;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(IWriterMessageService writerMessage, UserManager<AppUser> userManager)
        {
            _writerMessage = writerMessage;
            _userManager = userManager;
        }
        [Route("")]
        [Route("Inbox")]
        public async Task<IActionResult> Inbox()
        {
            var onlineUser =await _userManager.FindByNameAsync(User.Identity.Name);           
            var values = _writerMessage.GetListByInbox(onlineUser.Email);
            return View(values);
        }
        [Route("")]
        [Route("Sendbox")]
        public async Task<IActionResult> Sendbox()
        {
            var onlineUser = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _writerMessage.GetListBySendbox(onlineUser.Email);
            return View(values);
        }

        [Route("")]
        [Route("MessageDetails/{id}")]
        public ActionResult MessageDetails(int id)
        {
            var values = _writerMessage.TGetById(id);
            return View(values);
        }
        [Route("")]
        [Route("MessageDetailsWithSendbox/{id}")]
        public ActionResult MessageDetailsWithSendbox(int id)
        {
            var values = _writerMessage.TGetById(id);
            return View(values);
        }
        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = user.Email;
            var receiverNameSurname = await _userManager.FindByEmailAsync(p.Receiver);
            p.Date = DateTime.Now;
            p.Sender = mail;
            p.SenderName = user.Name+ " " +user.Surname;
            p.ReceiverName = receiverNameSurname.Name + " " + receiverNameSurname.Surname;
            _writerMessage.TAdd(p);
            return RedirectToAction("Sendbox");
        }



    }
}
