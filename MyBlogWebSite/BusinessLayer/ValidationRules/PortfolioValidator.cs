using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator: AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen proje adı alanı doldurunuz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Lütfen proje resmi alanı doldurunuz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Lütfen proje ücret alanı doldurunuz.");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Lütfen proje bitiş oran alanı doldurunuz.");
            RuleFor(x => x.ProjectImage).NotEmpty().WithMessage("Lütfen proje platform resim alanı doldurunuz.");
        }
    }
}
