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
    [Authorize(Roles ="Admin")]
    public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }


        public IActionResult Index()
        {
            var values = _experienceService.TGetList();
            return View(values);
        }
    
    
        [HttpGet]
        public IActionResult AddExperience()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {

            ExperienceValidator validations = new ExperienceValidator();
            ValidationResult result = validations.Validate(experience);

            if (result.IsValid)
            {
                _experienceService.TAdd(experience);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(experience);
        }


        public IActionResult DeleteExperience(int id)
        {
            var values = _experienceService.TGetById(id);
            _experienceService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = _experienceService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            ExperienceValidator validations = new ExperienceValidator();
            ValidationResult result = validations.Validate(experience);
            if (result.IsValid)
            {
                _experienceService.TUpdate(experience);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            
            return View(experience);
        }


    }
}
