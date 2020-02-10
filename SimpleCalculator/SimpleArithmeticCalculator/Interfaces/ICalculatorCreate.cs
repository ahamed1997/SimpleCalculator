// <copyright file="ICalculatorCreate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculator.Interfaces
{
    using SimpleArithmeticCalculator.Enums;

    /// <summary>
    /// Interface to input command type from user.
    /// </summary>
    public interface ICalculatorCreate
    {
        /// <summary>
        /// Method Create Command which inputs command type from user.
        /// </summary>
        /// <param name="commandType">Inputs Command type.</param>
        /// <returns>Selects the command and perform calculation.</returns>
         ICalculatorCommand CreateCommand(CommandType commandType);
    }
}
