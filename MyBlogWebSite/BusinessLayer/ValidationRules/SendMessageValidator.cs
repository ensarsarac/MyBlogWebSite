using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SendMessageValidator : AbstractValidator<Message>
    {
        public SendMessageValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen ad alanını doldurunuz.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz.");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter giriniz.");

            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen mail alanını doldurunuz.");

            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen mesaj alanını doldurunuz.");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Lütfen en az 20 karakter giriniz.");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakter giriniz.");

        }
    }
}
