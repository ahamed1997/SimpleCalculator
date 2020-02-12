// <copyright file="CalculatorDivisionCommandTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SimpleArithmeticCalculatorTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SimpleArithmeticCalculator.Enums;
    using SimpleArithmeticCalculator.Interfaces;

    [TestClass]
    public class CalculatorDivisionCommandTest
    {
        private Mock<ICalculateCommandFactory> calculateCommandFactoryMock;
        private ICalculateCommandFactory calculateCommandFactory;

        private Mock<ICalculatorCommand> calculatorCommandMock;
        private ICalculatorCommand calculatorCommand;

        [TestInitialize]
        public void TestInitialize()
        {
            this.calculateCommandFactoryMock = new Mock<ICalculateCommandFactory>();
            this.calculatorCommandMock = new Mock<ICalculatorCommand>();

            this.calculateCommandFactory = this.calculateCommandFactoryMock.Object;
            this.calculatorCommand = this.calculatorCommandMock.Object;
        }

        [TestMethod]
        public void DivideTest()
        {
            // Arrange
            double expectedValue = 5;
            this.calculatorCommandMock.Setup(x => x.Calculate(10, 2)).Returns(5);
            this.calculateCommandFactoryMock.Setup(x => x.CreateCommand(CommandType.Divide)).Returns(this.calculatorCommandMock.Object);
            var command = this.calculateCommandFactory.CreateCommand(CommandType.Divide);
            var value = command.Calculate(10, 2);

            // Act
            double actualValue = command.Calculate(10, 2);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        public void TestMethod()
        {
            var factory = new MockFactory(MockBehavior.Strict);

            var calculatorCommand = factory.Create<ICalculatorCommand>();

            // no need to call Verifiable() on the setup 
            // as we'll be validating all of them anyway.
            calculatorCommand.Setup(x => x.Calculate(2, 2));

            // exercise the mocks here

            calculatorCommand.VerifyAll();
        }
    }
}
