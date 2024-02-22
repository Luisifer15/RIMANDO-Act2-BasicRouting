using Microsoft.AspNetCore.Mvc;
using System;

namespace Act2___BasicRouting.Controllers
{
    public class OperationsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Change the URL to the following format: https://www.localhost:[port]/Operations/{operation}/{num1}/{num2}.");
        }
        public IActionResult Add(int num1, int num2)
        {
            int sum = (num1 + num2);
            return Content($"{num1} + {num2} = {sum}");
        }
        public IActionResult Subtract(int num1, int num2)
        {
            int diff = (num1 - num2);
            return Content($"{num1} - {num2} = {diff}");
        }
        public IActionResult Multiply(int num1, int num2)
        {
            int prod = (num1 * num2);
            return Content($"{num1} * {num2} = {prod}");
        }
        public IActionResult Divide(int num1, int num2)
        {
            float quot = ((float)num1 / (float)num2);
            return Content($"{num1} / {num2} = {quot}");
        }


    }
}
