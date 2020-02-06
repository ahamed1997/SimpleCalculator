using SimpleArithmeticCalculator.Interfaces;

namespace SimpleArithmeticCalculator.Commands
{
    public  class MultiplicationCommand : ICalculatorCommand
    {
        public double Calculate(double firstValue,double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
