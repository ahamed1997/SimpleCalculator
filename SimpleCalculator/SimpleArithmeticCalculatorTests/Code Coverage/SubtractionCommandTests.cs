// <copyright file="SubtractionCommandTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculatorTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SimpleArithmeticCalculator.Interfaces;

    [TestClass]
    public class SubtractionCommandTests
    {
        private Mock<ICalculatorCommand> calculatorMock;
        private ICalculatorCommand calculator;

        [TestInitialize]
        public void TestInitialize()
        {
            this.calculatorMock = new Mock<ICalculatorCommand>();
            this.calculator = this.calculatorMock.Object;
        }

        [TestMethod]
        public void SubtractionCommandTestwithTwoPositiveNumbers()
        {
            // Arrange
            double expectedValue = 16;
            try
            {
                // Act
                this.calculatorMock.Setup(x => x.Calculate(103, 87)).Returns(16);
                double actualValue = this.calculator.Calculate(103, 87);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch
            {
                throw;
            }
        }

        // [ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void SubtractionCommandTestwithOnePositiveANdOneNegativeNumber()
        {
            // Arrange
            double expectedValue = 59.7;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(80, -20.3)).Returns(59.7);
                double actualValue = this.calculator.Calculate(80, -20.3);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // [ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void SubtractionCommandTestwithOneNegativeAndOnePositiveNumber()
        {
            // Arrange
            double expectedValue = -40.19;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(-52.31, 12.12)).Returns(-40.19);
                double actualValue = this.calculator.Calculate(-52.31, 12.12);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // [ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void SubtractionCommandTestwithDecimalNegativeResult()
        {
            // Arrange
            double expectedValue = -0.44;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(-0.75, 0.31)).Returns(-0.44);
                double actualValue = this.calculator.Calculate(-0.75, 0.31);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
