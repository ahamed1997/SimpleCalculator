// <copyright file="ICalculatorCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculator.Interfaces
{
    /// <summary>
/// ICalculatorCommand interface created.
/// </summary>
    public interface ICalculatorCommand
    {/// <summary>
    /// Calculate method to compute values.
    /// </summary>
    /// <param name="firstValue">Inputs first value.</param>
    /// <param name="secondValue">Inputs Secon value.</param>
    /// <returns>Returns the result.</returns>
        double Calculate(double firstValue, double secondValue);
    }
}
