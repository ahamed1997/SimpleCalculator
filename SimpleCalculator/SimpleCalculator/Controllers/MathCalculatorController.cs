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
        public double ArithmeticCalculator(double firstValue=0, double secondValue=0, int operationType=1)
        {

            var commandType = (CommandType)operationType;
            CalculatorCreate calculator = new CalculatorCreate();
            double output = calculator.CreateCommand(commandType).Calculate(firstValue, secondValue);
            return output;
        }
       
    }
}