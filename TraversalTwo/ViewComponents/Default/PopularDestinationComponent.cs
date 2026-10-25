using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalTwo.ViewComponents.Default
{
    public class PopularDestinationComponent : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public PopularDestinationComponent(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
    }
}
