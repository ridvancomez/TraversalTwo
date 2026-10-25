using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalTwo.ViewComponents.Default
{
    public class FeatureComponent : ViewComponent
    {

        private readonly IFeatureService _featureService;

        public FeatureComponent(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _featureService.TGetList();
            return View(values);
        }
    }
}
