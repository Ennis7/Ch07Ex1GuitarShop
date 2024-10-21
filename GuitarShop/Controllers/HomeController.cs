using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
        //Step 14.)
        [Route("[action]")]
        public IActionResult ContactUs()
        {
            //Step 19.)
            var contact = new Dictionary<string, string> {                 { "Phone", "555-123-4567" },                 { "Email", "info@myguitarshop.com" }            };
            return View(contact);
        }
    }
}
