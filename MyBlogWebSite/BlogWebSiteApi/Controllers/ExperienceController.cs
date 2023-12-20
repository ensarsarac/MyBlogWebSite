using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebSiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetExperience()
        {
            var c = new Context();
            return Ok(c.Experiences.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var c = new Context();
            return Ok(c.Experiences.Find(id));
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            var c = new Context();
            c.Experiences.Add(p);
            c.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveExperience(int id)
        {
            var c = new Context();
            var value = c.Experiences.Find(id);
            c.Experiences.Remove(value);
            c.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateExperience(Experience p)
        {
            var c = new Context();
            c.Experiences.Update(p);
            c.SaveChanges();
            return Ok();
        }


    }
}
