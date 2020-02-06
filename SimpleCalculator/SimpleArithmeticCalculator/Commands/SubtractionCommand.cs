using SimpleArithmeticCalculator.Interfaces;

namespace SimpleArithmeticCalculator.Commands
{
    public class SubtractionCommand : ICalculatorCommand
   {
        public double Calculate(double firstValue,double secondValue)
        {
            return firstValue - secondValue;
        }
   }
}
