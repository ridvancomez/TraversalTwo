using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class About2Validator:AbstractValidator<About2>
    {
        public About2Validator()
        {
            RuleFor(x => x.Title1).NotEmpty().WithMessage("Başlık1 kısmı boş geçilemez");
            RuleFor(x => x.Title2).NotEmpty().WithMessage("Başlık2 kısmı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Resim kısmı boş geçilemez");
        }
    }
}
