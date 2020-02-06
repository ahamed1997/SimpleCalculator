using SimpleArithmeticCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
