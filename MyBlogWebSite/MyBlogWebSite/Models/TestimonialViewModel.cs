using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Models
{
    public class TestimonialViewModel
    {
        [Required(ErrorMessage ="Bu alan zorunlu.")]
        public string ClientName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu.")]
        public string Company { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu.")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu.")]
        public IFormFile ImageUrl { get; set; }
    }
}
