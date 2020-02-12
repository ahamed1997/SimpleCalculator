// <copyright file="CalculatorAdditionCommandTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculatorTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SimpleArithmeticCalculator.Enums;
    using SimpleArithmeticCalculator.Interfaces;

    /// <summary>
    /// Addition Command Test Class.
    /// </summary>
    [TestClass]
    public class CalculatorAdditionCommandTest
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
        /// Addition Test.
        /// </summary>
        [TestMethod]
        public void AdditionTest()
        {
            // Arrange
            double expectedValue = 5;
            this.calculatorCommandMock.Setup(x => x.Calculate(3, 2)).Returns(5);
            this.calculateCommandFactoryMock.Setup(x => x.CreateCommand(CommandType.Add)).Returns(this.calculatorCommandMock.Object);
            var command = this.calculateCommandFactory.CreateCommand(CommandType.Add);
            var value = command.Calculate(3, 2);

            // Act
            double actualValue = command.Calculate(3, 2);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
