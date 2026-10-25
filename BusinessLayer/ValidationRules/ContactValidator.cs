using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim kısmı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Email kısmı boş geçilemez");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Konu kısmı boş geçilemez");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj kısmı boş geçilemez");
            RuleFor(x => x.MapLocation).NotEmpty().WithMessage("Harita konumu kısmı boş geçilemez");
        }
    }
}
