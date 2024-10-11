using ClimateControlWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClimateControlWebsite.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Климатик A", Description = "Мощен климатик за големи помещения.", Price = 1200 },
                new Product { Id = 2, Name = "Климатик B", Description = "Енергоспестяващ и ефективен.", Price = 900 }
            };
            return View(products);
        }
    }
}
