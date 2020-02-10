// <copyright file="SubtractionCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculator.Commands
{
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// SubtractionCommand implements ICalculatorCommand.
    /// </summary>
    public class SubtractionCommand : ICalculatorCommand
    {
        /// <summary>
        /// Method Calculate.
        /// </summary>
        /// <param name="firstValue">Inputs first value.</param>
        /// <param name="secondValue">Inputs second value.</param>
        /// <returns>Returns Subtracted result.</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
   }
}
