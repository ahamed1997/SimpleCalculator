// <copyright file="AddCommandTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace SimpleArithmeticCalculatorTests
#pragma warning restore SA1652 // Enable XML documentation output
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SimpleArithmeticCalculator.Interfaces;

    [TestClass]
    public class AddCommandTests
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
        public void AddCommandTest_withTwoIntegers()
        {
            // Arrange
            double expectedValue = 133.4;
            this.calculatorMock.Setup(x => x.Calculate(70.1, 63.3)).Returns(133.4);

            // Act
            double actualValue = this.calculator.Calculate(70.1, 63.3);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
            this.calculatorMock.Verify(x => x.Calculate(It.IsAny<double>(), It.IsAny<double>()), Times.Once());
        }

        // [ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void AddCommandTest_withTwoNegativeInteger()
        {
            // Arrange
            double expectedValue = -100;

            // Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(-80, -20)).Returns(-100);
                double actualValue = this.calculator.Calculate(-80, -20);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
