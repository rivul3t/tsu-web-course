using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using lab12.Models;

namespace lab12.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ICalculationService _calculationService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [HttpPost]
        public IActionResult ManualParsingSingleAction()
        {
            string result = null;
            double number1 = 0;
            double number2 = 0;
            string operation = null;

            if (Request.Method == "POST")
            {
                number1 = double.TryParse(Request.Form["Number1"], out var n1) ? n1 : 0;
                number2 = double.TryParse(Request.Form["Number2"], out var n2) ? n2 : 0;
                operation = Request.Form["Operation"];

                result = operation switch
                {
                    "+" => (number1 + number2).ToString(),
                    "-" => (number1 - number2).ToString(),
                    "*" => (number1 * number2).ToString(),
                    "/" => number2 != 0 ? (number1 / number2).ToString() : "Ошибка: деление на ноль",
                    _ => "Неизвестная операция"
                };
            }
            ViewBag.Number1 = number1; 
            ViewBag.Number2 = number2;
            ViewBag.Operation = operation;
            ViewBag.Result = result;
            ViewData["Result"] = result;
            return View();
        }

        [HttpGet]
        public IActionResult ManualParsingSeparateAction(int? id = null)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ManualParsingSeparateAction()
        {
            string result = null;
            double number1 = 0;
            double number2 = 0;
            string operation = null;

            if (Request.Method == "POST")
            {
                number1 = double.TryParse(Request.Form["Number1"], out var n1) ? n1 : 0;
                number2 = double.TryParse(Request.Form["Number2"], out var n2) ? n2 : 0;
                operation = Request.Form["Operation"];

                result = operation switch
                {
                    "+" => (number1 + number2).ToString(),
                    "-" => (number1 - number2).ToString(),
                    "*" => (number1 * number2).ToString(),
                    "/" => number2 != 0 ? (number1 / number2).ToString() : "Ошибка: деление на ноль",
                    _ => "Неизвестная операция"
                };
            }
            ViewBag.Number1 = number1; 
            ViewBag.Number2 = number2;
            ViewBag.Operation = operation;
            ViewBag.Result = result;
            ViewData["Result"] = result;
            return View();
        }

        [HttpGet]
        public IActionResult ModelBindingParameters(int? id = null)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModelBindingParameters(double number1, double number2, string operation)
        {
            string result = null;

                result = operation switch
                {
                    "+" => (number1 + number2).ToString(),
                    "-" => (number1 - number2).ToString(),
                    "*" => (number1 * number2).ToString(),
                    "/" => number2 != 0 ? (number1 / number2).ToString() : "Ошибка: деление на ноль",
                    _ => "Неизвестная операция"
                };

            ViewBag.Result = result;
            ViewData["Result"] = result;
            return View();
        }


        [HttpGet]
        public IActionResult ModelBindingSeparateModel(int? id = null)
        {
            return View(new Value());
        }

        [HttpPost]
        public IActionResult ModelBindingSeparateModel(Value model)
        {
            model.Result = null;

            model.Result = model.Operation switch
            {
                "+" => (model.Number1 + model.Number2).ToString(),
                "-" => (model.Number1 - model.Number2).ToString(),
                "*" => (model.Number1 * model.Number2).ToString(),
                "/" => model.Number2 != 0 ? (model.Number1 / model.Number2).ToString() : "Ошибка: деление на ноль",
                _ => "Неизвестная операция"
            };

            return View(model);
        }

    }
}