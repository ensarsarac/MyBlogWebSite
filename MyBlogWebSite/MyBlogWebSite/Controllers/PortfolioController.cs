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
    [Authorize(Roles = "Admin,Moderator")]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {

            return View(_portfolioService.TGetList());
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult result = validator.Validate(portfolio);

            if (result.IsValid)
            {
                portfolio.Image1 = "/argon-dashboard-master/assets/img/theme/team-1.jpg";
                portfolio.Image2 = "/argon-dashboard-master/assets/img/theme/team-2.jpg";
                portfolio.Image3 = "/argon-dashboard-master/assets/img/theme/team-3.jpg";
                portfolio.Image4 = "/argon-dashboard-master/assets/img/theme/team-4.jpg";
                if(portfolio.Value >= 90)
                {
                    portfolio.Status = true;
                }
                else
                {
                    portfolio.Status = false;
                }

                _portfolioService.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(portfolio);
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = _portfolioService.TGetById(id);
            _portfolioService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = _portfolioService.TGetById(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);
            if (result.IsValid)
            {
                
                _portfolioService.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(portfolio);
        }

    }
}
