using Microsoft.AspNetCore.Mvc;

namespace ClimateControlWebsite.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
