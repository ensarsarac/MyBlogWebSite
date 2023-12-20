using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ContactSubContent : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());

        public IActionResult Index()
        {
            
            return View(cm.TGetList());
        }

        public IActionResult Delete(int id)
        {
            var value = cm.TGetById(id);
            cm.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(cm.TGetById(id));
        }
        [HttpPost]
        public IActionResult Update(Contact p)
        {
            cm.TUpdate(p);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Contact p)
        {
            p.Status = false;
            cm.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult Active(int id)
        {
            var value = cm.TGetById(id);
            value.Status = true;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }
        public IActionResult Passive(int id)
        {
            var value = cm.TGetById(id);
            value.Status = false;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }





    }
}
