using Microsoft.AspNetCore.Mvc;

namespace Ch02EX1FutureValue
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Mary";
            ViewBag.FV = 99999.99;
            return View();
        }
    }
}
