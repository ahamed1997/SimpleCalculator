﻿// <copyright file="MathCalculatorController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleCalculator.Controllers
{
    using System.Web.Http.Cors;
    using Microsoft.AspNetCore.Mvc;
    using SimpleArithmeticCalculator;
    using SimpleArithmeticCalculator.Enums;

    /// <summary>
    /// New Controller MathCalculatorController is created.
    /// </summary>
    [EnableCors("http://localhost:4200", "*", "GET,PUT,POST")]

    public class MathCalculatorController : Controller
    {
        /// <summary>
        /// AritheticCalculator Method.
        /// </summary>
        /// <param name="firstValue">Inputs first param.</param>
        /// <param name="secondValue">Inputs second param.</param>
        /// <param name="operation">Type of operation.</param>
        /// <returns>Returns calculated output.</returns>
        [HttpGet]
        public double ArithmeticCalculator(double firstValue, double secondValue, int operation)
        {
            var choice = (CommandType)operation;
            CalculatorCreate calculator = new CalculatorCreate();
            double output = calculator.CreateCommand(choice).Calculate(firstValue, secondValue);
            return output;
        }

        /// <summary>
        /// Method Result To check its true.
        /// </summary>
        /// <returns>returns bool value after calculation.</returns>
        [HttpGet]
        public bool Result()
        {
            return true;
        }
    }
}