using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator: AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlık alanını doldurunuz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen açıklama alanını doldurunuz");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Lütfen yaş alanını doldurunuz");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Lütfen telefon numarası alanını doldurunuz");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Lütfen adres alanını doldurunuz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen resim alanını doldurunuz");
        }
    }
}
