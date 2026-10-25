using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class FeatureValidator: AbstractValidator<Feature>
    {
        public FeatureValidator() 
        { 
            RuleFor(x => x.Post).NotEmpty().WithMessage("Gönderi alanı boş geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Resim alanı boş geçilemez.");

        }
    }
}
