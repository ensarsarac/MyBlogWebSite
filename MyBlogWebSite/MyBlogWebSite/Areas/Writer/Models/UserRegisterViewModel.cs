using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen ad alanını boş bırakmayınız.")]
        
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyad alanını boş bırakmayınız.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı alanını boş bırakmayınız.")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mail alanını boş bırakmayınız.")]

        public string Email { get; set; }

        
        [Required(ErrorMessage = "Lütfen resim alanını boş bırakmayınız.")]

        public string Image { get; set; }

        [Required(ErrorMessage = "Lütfen şifre alanını boş bırakmayınız.")]


        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifre tekrar alanını boş bırakmayınız.")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil!.")]

        public string ConfirmPassword { get; set; }
    }
}
