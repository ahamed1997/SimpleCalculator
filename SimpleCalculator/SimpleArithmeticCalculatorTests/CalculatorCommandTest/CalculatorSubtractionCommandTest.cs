using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using SimpleArithmeticCalculator.Interfaces;
using SimpleArithmeticCalculator.Enums;
namespace SimpleArithmeticCalculatorTests
{
    [TestClass]
    public class CalculatorSubtractionCommandTest
    {
        private Mock<ICalculateCommandFactory> calculateCommandFactoryMock;
        private ICalculateCommandFactory calculateCommandFactory;

        private Mock<ICalculatorCommand> calculatorCommandMock;
        private ICalculatorCommand calculatorCommand;

        [TestInitialize]
        public void TestInitialize()
        {
            calculateCommandFactoryMock = new Mock<ICalculateCommandFactory>();
            calculatorCommandMock = new Mock<ICalculatorCommand>();

            this.calculateCommandFactory = this.calculateCommandFactoryMock.Object;
            calculatorCommand = calculatorCommandMock.Object;
        }

        [TestMethod]
        public void SubtractTests()
        {
            //Arrange 
            double expectedValue = 8;
            calculatorCommandMock.Setup(x => x.Calculate(10, 2)).Returns(8);
            calculateCommandFactoryMock.Setup(x => x.CreateCommand(CommandType.Divide)).Returns(calculatorCommandMock.Object);
            var command = calculateCommandFactory.CreateCommand(CommandType.Divide);
            var value = command.Calculate(10, 2);
            //Act
            double actualValue = command.Calculate(10, 2);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
