using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalTwo.ViewComponents.Default
{
    public class TestimonialComponent:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;
        public TestimonialComponent(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetList();
            return View(values);
        }
    }
}
