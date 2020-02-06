using Microsoft.AspNetCore.Mvc;
using SimpleArithmeticCalculator;
using SimpleArithmeticCalculator.Enums;
using System.Web.Http.Cors;

namespace SimpleCalculator.Controllers
{
   [EnableCors("http://localhost:4200", "*", "GET,PUT,POST")]

    public class MathCalculatorController : Controller
    {
        [HttpGet]
        public double ArithmeticCalculator(double firstValue, double secondValue, int operation)
        {

            var choice = (CommandType)operation;
            CalculatorCreate calculator = new CalculatorCreate();
            double output = calculator.CreateCommand(choice).Calculate(firstValue, secondValue);
            return output;
        }
        [HttpGet]
        public bool result()
        {
            return true;
        }
    }
}