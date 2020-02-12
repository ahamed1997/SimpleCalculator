// <copyright file="IMathController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculator.Interfaces
{
    /// <summary>
    /// Interface for WebAPI controller.
    /// </summary>
    public interface IMathController
    {
        /// <summary>
        /// Method recieve request and send backs the response.
        /// </summary>
        /// <param name="firstValue">Recieves Operand1.</param>
        /// <param name="secondValue">Recieves Operand2.</param>
        /// <param name="operationType">Operators Type.</param>
        /// <returns>Calculation result.</returns>
        double ArithmeticCalculator(double firstValue, double secondValue, int operationType);

    }
}
