using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class DestinationValidator:AbstractValidator<Destination>
    {
        public DestinationValidator()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir kısmı boş geçilemez");
            RuleFor(x => x.DayNight).NotEmpty().WithMessage("Gün/Gece kısmı boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat kısmı boş geçilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Resim kısmı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez");
            RuleFor(x => x.Capacity).NotEmpty().WithMessage("Kapasite kısmı boş geçilemez");
        }
    }
}
