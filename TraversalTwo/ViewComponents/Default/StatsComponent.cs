using Microsoft.AspNetCore.Mvc;

namespace TraversalTwo.ViewComponents.Default
{
    public class StatsComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
