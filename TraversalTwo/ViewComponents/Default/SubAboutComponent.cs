using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalTwo.ViewComponents.Default
{
    public class SubAboutComponent:ViewComponent
    {
        private readonly ISubAboutService _supaboutService;
        public SubAboutComponent(ISubAboutService supaboutService)
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
