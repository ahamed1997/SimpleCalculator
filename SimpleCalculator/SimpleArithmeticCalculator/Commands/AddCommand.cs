// <copyright file="AddCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculator.Commands
{
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// AddCommand implements ICalculatorCommand.
    /// </summary>
    public class AddCommand : ICalculatorCommand
    {
        /// <summary>
        /// Method Calculate to perform all operations.
        /// </summary>
        /// <param name="firstValue">Inputs first value.</param>
        /// <param name="secondValue">Inputs second Value.</param>
        /// <returns>Return addition result.</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
