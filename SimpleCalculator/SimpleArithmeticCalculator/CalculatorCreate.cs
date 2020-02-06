using SimpleArithmeticCalculator.Commands;
using SimpleArithmeticCalculator.Enums;
using SimpleArithmeticCalculator.Interfaces;
using System;

namespace SimpleArithmeticCalculator
{
    public class CalculatorCreate : ICalculatorCreate
    {
        public ICalculatorCommand CreateCommand(CommandType commandType)
        {
            switch (commandType)
            {
                case CommandType.Add:
                    return new AddCommand();
                case CommandType.Subtract:
                    return new SubtractionCommand();
                case CommandType.Multiply:
                    return new MultiplicationCommand();
                case CommandType.Divide:
                    return new DivideCommand();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
