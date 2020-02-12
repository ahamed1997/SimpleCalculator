// <copyright file="CalculatorSubtractionCommandTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculatorTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SimpleArithmeticCalculator.Enums;
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// Subtraction Command Test Class.
    /// </summary>
    [TestClass]
    public class CalculatorSubtractionCommandTest
    {
        private Mock<ICalculateCommandFactory> calculateCommandFactoryMock;
        private ICalculateCommandFactory calculateCommandFactory;

        private Mock<ICalculatorCommand> calculatorCommandMock;
        private ICalculatorCommand calculatorCommand;

        /// <summary>
        /// Test Initialization.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            this.calculateCommandFactoryMock = new Mock<ICalculateCommandFactory>();
            this.calculatorCommandMock = new Mock<ICalculatorCommand>();

            this.calculateCommandFactory = this.calculateCommandFactoryMock.Object;
            this.calculatorCommand = this.calculatorCommandMock.Object;
        }

        /// <summary>
        /// Subtraction Test Method.
        /// </summary>
        [TestMethod]
        public void SubtractTests()
        {
            // Arrange
            double expectedValue = 8;
            this.calculatorCommandMock.Setup(x => x.Calculate(10, 2)).Returns(8);
            this.calculateCommandFactoryMock.Setup(x => x.CreateCommand(CommandType.Divide)).Returns(this.calculatorCommandMock.Object);
            var command = this.calculateCommandFactory.CreateCommand(CommandType.Divide);
            var value = command.Calculate(10, 2);

            // Act
            double actualValue = command.Calculate(10, 2);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
