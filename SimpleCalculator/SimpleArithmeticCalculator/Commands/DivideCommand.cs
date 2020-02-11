// <copyright file="DivideCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculator.Commands
{
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// DivideCommand implements ICalculatorCommand.
    /// </summary>
    public class DivideCommand : ICalculatorCommand
    {
        /// <summary>
        /// Method Calculate.
        /// </summary>
        /// <param name="firstValue">Inputs first value.</param>
        /// <param name="secondValue">Inputs second value.</param>
        /// <returns>Return addition result.</returns>
        public double Calculate(double firstValue, double secondValue) => firstValue / secondValue;
    }
}
