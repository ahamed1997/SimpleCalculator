// <copyright file="CalculatorCreate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculator
{
    using System;
    using SimpleArithmeticCalculator.Commands;
    using SimpleArithmeticCalculator.Enums;
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// Class CalculatorCreate depends ICalculatorCreate Interface.
    /// </summary>
    public class CalculatorCreate : ICalculatorCreate
    {/// <summary>
    /// CreateCommmand Method is created.
    /// </summary>
    /// <param name="commandType">commandType is created as parameter.</param>
    /// <returns>Select the particular commandType and perform calculations.</returns>
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
