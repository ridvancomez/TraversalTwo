using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SubAboutValidator : AbstractValidator<SubAbout>
    {
        public SubAboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmı boş geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez.");
        }
    }
}
