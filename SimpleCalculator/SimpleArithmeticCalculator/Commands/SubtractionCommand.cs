using SimpleArithmeticCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
