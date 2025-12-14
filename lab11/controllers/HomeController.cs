using lab11;
using Microsoft.AspNetCore.Mvc;
namespace lab11
{
    public class CalcServiceController : Controller
    {
        public IActionResult PassUsingModel()
        {
            int a = 6, b = 8;
            var model = new CalcModel
            {
                First = a,
                Second = b,
                Sum = a + b,
                Sub = a - b,
                Mult = a * b,
                Div = (b != 0) ? a / b : 0
            };
            return View(model);
        }

        public IActionResult PassUsingViewData()
        {
            int a = 2, b = 1;
            ViewData["First"] = a;
            ViewData["Second"] = b;
            ViewData["Sum"] = a + b;
            ViewData["Sub"] = a - b;
            ViewData["Mult"] = a * b;
            ViewData["Div"] = (b != 0) ? a / b : 0;
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            int a = 8, b = 1;
            ViewBag.First = a;
            ViewBag.Second = b;
            ViewBag.Sum = a + b;
            ViewBag.Sub = a - b;
            ViewBag.Mult = a * b;
            ViewBag.Div = (b != 0) ? a / b : 0;
            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            int a = 5, b = 0;
            ViewBag.First = a;
            ViewBag.Second = b;
            ViewBag.Sum = a + b;
            ViewBag.Sub = a - b;
            ViewBag.Mult = a * b;
            ViewBag.Div = (b != 0) ? a / b : 0;
            return View();
        }
    }
}
