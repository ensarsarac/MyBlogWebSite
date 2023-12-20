using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Areas.Writer.Models
{
    public class ProfileViewModel
    {
        [Required(ErrorMessage ="Ad alanını doldurunuz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanını doldurunuz.")]

        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı alanını doldurunuz.")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Email alanını doldurunuz.")]

        public string Email { get; set; }

        public string Password { get; set; }
        public IFormFile Image { get; set; }
    }
}
