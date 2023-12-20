using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class FeatureValidator:  AbstractValidator<Feature>
    {
        public FeatureValidator()
        {
            RuleFor(x => x.Header).NotEmpty().WithMessage("Lütfen başlık alanını doldurunuz.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen ad soyad alanını doldurunuz.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen görev alanını doldurunuz.");
        }
    }
}
