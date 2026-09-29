using Microsoft.AspNetCore.Mvc;

namespace q7.Controllers
{
    public class CalculatorController : Controller
    {
        // Display calculator page
        public IActionResult Index()
        {
            return View();
        }

        // Perform calculation
        [HttpPost]
        public IActionResult Calculate(
            double number1,
            double number2,
            string operation)
        {
            double result = 0;

            if (operation == "add")
            {
                result = number1 + number2;
            }
            else if (operation == "subtract")
            {
                result = number1 - number2;
            }
            else if (operation == "divide")
            {
                if (number2 == 0)
                {
                    ViewBag.Error = "Cannot divide by zero.";

                    return View("Index");
                }

                result = number1 / number2;
            }

            ViewBag.Result = result;

            return View("Index");
        }
    }
}
