using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalTwo.ViewComponents.Default
{
    public class SliderComponent:ViewComponent
    {
        private readonly ISubAboutService _supaboutService;
        public SliderComponent(ISubAboutService supaboutService)
        {
            _supaboutService = supaboutService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _supaboutService.TGetList();
            return View(values);
        }
    }
}
