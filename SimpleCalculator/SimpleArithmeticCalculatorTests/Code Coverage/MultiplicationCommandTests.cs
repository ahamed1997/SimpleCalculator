// <copyright file="MultiplicationCommandTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculatorTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// Multiplication Test Class.
    /// </summary>
    [TestClass]
    public class MultiplicationCommandTests
    {
        private Mock<ICalculatorCommand> calculatorMock;
        private ICalculatorCommand calculator;

        /// <summary>
        /// Test Initialization.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            this.calculatorMock = new Mock<ICalculatorCommand>();
            this.calculator = this.calculatorMock.Object;
        }

        /// <summary>
        /// Test Method for Multiplication Operation.
        /// </summary>
        [TestMethod]
        public void MultiplicationTest()
        {
            // Arrange
            double expectedValue = 400;
            try
            {
                // Act
                this.calculatorMock.Setup(x => x.Calculate(20, 20)).Returns(400);
                double actualValue = this.calculator.Calculate(20, 20);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Exception Test Case One.
        /// </summary>
        [TestMethod]
        public void MultiplicationCommandTestwithTwoNegativeInteger()
        {
            // Arrange
            double expectedValue = 160;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(40, 40)).Returns(160);
                double actualValue = this.calculator.Calculate(40, 40);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Exception Test Case two.
        /// </summary>
        [TestMethod]
        public void MultiplicationCommandTestwithOnenegativeandOnepositiveInteger()
        {
            // Arrange
            double expectedValue = -1343.16;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(16.57, 81.06)).Returns(-1343.16);
                double actualValue = this.calculator.Calculate(16.57, 81.06);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Exception test case three.
        /// </summary>
        [TestMethod]
        public void MultiplicationCommandTestwithDecimalPositiveInteger()
        {
            // Arrange
            double expectedValue = 0.202;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(0.132, 1.53)).Returns(0.202);
                double actualValue = this.calculator.Calculate(0.132, 1.53);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
