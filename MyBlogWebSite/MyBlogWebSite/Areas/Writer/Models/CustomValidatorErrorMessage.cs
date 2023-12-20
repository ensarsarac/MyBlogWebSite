using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogWebSite.Areas.Writer.Models
{
    public class CustomValidatorErrorMessage : IdentityErrorDescriber 
    {
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "En az bir tane alfabetik numara olmalıdır."
            };
        }




        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Şifreler en az bir rakamdan oluşmalıdır."
            };
        }



        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description="En az bir tane küçük harf bulunmalıdır."
            };
        }


        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "En az bir tane büyük harf olmalıdır."
            };
        }


    }
}
