using Microsoft.AspNetCore.Mvc;

namespace lab11 {
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}