// <copyright file="DivisionCommandTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculatorTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// Test Class for Division.
    /// </summary>
    [TestClass]
    public class DivisionCommandTests
    {
        private Mock<ICalculatorCommand> calculatorMock;
        private ICalculatorCommand calculator;

        /// <summary>
        /// Test Initializing.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            this.calculatorMock = new Mock<ICalculatorCommand>();
            this.calculator = this.calculatorMock.Object;
        }

        /// <summary>
        /// Division Test Method.
        /// </summary>
        [TestMethod]
        public void DivisionCommandTest()
        {
            // Arrange
            double expectedValue = 41;
            try
            {
                // Act
                this.calculatorMock.Setup(x => x.Calculate(82, 2)).Returns(41);
                double actualValue = this.calculator.Calculate(82, 2);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        ///  Exception Test Cases One.
        /// </summary>
        [TestMethod]
        public void DivisionCommandTest_withTwoPositiveIntegerwithDecimal()
        {
            // Arrange
            double expectedValue = 0.6073;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(0.75, 1.235)).Returns(0.6073);
                double actualValue = this.calculator.Calculate(0.75, 1.235);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  Exception Test Cases Two.
        /// </summary>
        [TestMethod]
        public void DivisionCommandTestwithOnenegativeandOnepositiveInteger()
        {
            // Arrange
            double expectedValue = -4;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(80, -20)).Returns(-4);
                double actualValue = this.calculator.Calculate(80, -20);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  Exception Test Cases Three.
        /// </summary>
        [TestMethod]
        public void DivisionCommandTestwithTwoNegativeIntegers()
        {
            // Arrange
            double expectedValue = 0.5;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(-1, -2)).Returns(0.5);
                double actualValue = this.calculator.Calculate(-1, -2);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  Exception Test Cases Four.
        /// </summary>
        [TestMethod]
        public void DivisionCommandTest_DivideByZero()
        {
            // Arrange
            double expectedValue = 0;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(8, 0)).Returns(0);
                double actualValue = this.calculator.Calculate(8, 0);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  Exception Test Cases Five.
        /// </summary>
        [TestMethod]
        public void DivisionCommandTestDivideZeroByAnyNumber()
        {
            // Arrange
            double expectedValue = 0;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(0, 30)).Returns(0);
                double actualValue = this.calculator.Calculate(0, 30);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
