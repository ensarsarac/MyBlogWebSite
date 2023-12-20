using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ExperienceValidator: AbstractValidator<Experience>
    {
        public ExperienceValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen deneyim adı alanını doldurunuz.");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Lütfen deneyim tarih alanını doldurunuz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen deneyim açıklama alanını doldurunuz.");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakter giriniz.");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Lütfen en fazla 200 karakter giriniz.");
        }
    }
}
