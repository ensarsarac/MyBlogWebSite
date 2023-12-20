using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Controllers
{
    [Authorize(Roles ="Admin,Moderator")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }


        public IActionResult Index()
        {
            return View(_serviceService.TGetList());
        }

        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetById(id);
            _serviceService.TDelete(values);
            return RedirectToAction("Index");
        }
    
        [HttpGet]
        public IActionResult AddService()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            ServiceValidator validations = new ServiceValidator();
            ValidationResult result = validations.Validate(service);

            if (result.IsValid)
            {
                _serviceService.TAdd(service);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(service);
        }


        [HttpGet]
        public IActionResult UpdateService(int id)
        {

            return View(_serviceService.TGetById(id));
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {

            ServiceValidator validations = new ServiceValidator();
            ValidationResult result = validations.Validate(service);

            if (result.IsValid)
            {
                _serviceService.TUpdate(service);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(service);
        }



    }
}
