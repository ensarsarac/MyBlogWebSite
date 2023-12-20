using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Areas.Writer.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını doldurunuz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi doldurunuz.")]

        public string Password { get; set; }
    }
}
