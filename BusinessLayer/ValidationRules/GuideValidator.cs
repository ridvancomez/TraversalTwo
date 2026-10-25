using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Başlık kısmı boş geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Resim kısmı boş geçilemez.");
            RuleFor(x => x.TwitterUrl).NotEmpty().WithMessage("Twitter kısmı boş geçilemez.");
            RuleFor(x => x.InstagramUrl).NotEmpty().WithMessage("Instagram kısmı boş geçilemez.");

            

        }
    }
}
