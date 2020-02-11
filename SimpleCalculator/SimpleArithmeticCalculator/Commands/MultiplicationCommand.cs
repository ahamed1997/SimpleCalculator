// <copyright file="MultiplicationCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculator.Commands
{
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// MultiplicationCommand implements ICalculatorCommand.
    /// </summary>
    public class MultiplicationCommand : ICalculatorCommand
    {
        /// <summary>
        /// Method Calculate.
        /// </summary>
        /// <param name="firstValue">Inputs first value.</param>
        /// <param name="secondValue">Inputs second value.</param>
        /// <returns>Return Multiplication result.</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
