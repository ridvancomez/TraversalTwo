using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim kısmı boş geçilemez.");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Yorum kısmı boş geçilemez.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Resim kısmı boş geçilemez.");
        }
    }
}
