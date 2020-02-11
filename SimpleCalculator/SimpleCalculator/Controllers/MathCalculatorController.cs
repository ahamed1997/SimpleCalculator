// <copyright file="MathCalculatorController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleCalculator.Controllers
{
    using System.Web.Http.Cors;
    using Microsoft.AspNetCore.Mvc;
    using SimpleArithmeticCalculator;
    using SimpleArithmeticCalculator.Enums;
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// Controller MathCalculatorController is created.
    /// </summary>
    [EnableCors("http://localhost:4200", "*", "GET,PUT,POST")]

    public class MathCalculatorController : IMathController
    {
        /// <summary>
        /// API Request Recieving Method.
        /// </summary>
        /// <param name="firstValue">Inputs first param.</param>
        /// <param name="secondValue">Inputs second param.</param>
        /// <param name="operationType">Type of operation.</param>
        /// <returns>Returns calculated output.</returns>
        [HttpGet]
        public double ArithmeticCalculator(double firstValue = 0, double secondValue = 0, int operationType = 1)
        {
            Calculator calculator = new Calculator();            
            var commandType = (CommandType)operationType;
            var command = calculator.CreateCommand(commandType);
            double output = command.Calculate(firstValue, secondValue);
            return output;
        }
    }
}