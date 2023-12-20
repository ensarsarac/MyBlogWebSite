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
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }


        public IActionResult Index()
        {
            var values = _skillService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            SkillValidator validator = new SkillValidator();
            ValidationResult result = validator.Validate(skill);

            if (result.IsValid)
            {
                _skillService.TAdd(skill);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(skill);
        }


        [HttpGet]
        public IActionResult DeleteSkill(int id)
        {
            var values = _skillService.TGetById(id);
            _skillService.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = _skillService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            SkillValidator validations = new SkillValidator();
            ValidationResult result = validations.Validate(skill);
            if (result.IsValid)
            {
                
                _skillService.TUpdate(skill);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(skill);

            
        }

    }
}
