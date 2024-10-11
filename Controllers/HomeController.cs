using Microsoft.AspNetCore.Mvc;

namespace ClimateControlWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
