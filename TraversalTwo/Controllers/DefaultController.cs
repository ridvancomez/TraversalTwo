using Microsoft.AspNetCore.Mvc;

namespace TraversalTwo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
