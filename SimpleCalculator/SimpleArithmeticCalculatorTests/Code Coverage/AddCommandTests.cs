// <copyright file="AddCommandTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculatorTests
#pragma warning restore SA1652 // Enable XML documentation output
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SimpleArithmeticCalculator.Commands;
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// Test Class for Addition Operaion.
    /// </summary>
    [TestClass]
    public class AddCommandTests
    {
        private ICalculatorCommand addCommand;

        /// <summary>
        /// Addition Test Initializing.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            this.addCommand = new AddCommand();
        }

        /// <summary>
        /// Test for Constructor.
        /// </summary>
        [TestMethod]
        public void AddCommand_Constructor_Test()
        {
            // Arrange & Act
            this.addCommand = new AddCommand();

            // Assert
            Assert.IsNotNull(this.addCommand);
        }

        /// <summary>
        /// Test for two Integers.
        /// </summary>
        [TestMethod]
        public void AddCommand_Two_IntegerValues_Test()
        {
            // Arrange
            var input1 = 7;
            var input2 = 10;
            var expected = 17;

            // Act
            var actual = this.addCommand.Calculate(input1, input2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
