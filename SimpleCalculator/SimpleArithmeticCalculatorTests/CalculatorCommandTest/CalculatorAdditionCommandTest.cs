namespace SimpleArithmeticCalculatorTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SimpleArithmeticCalculator.Enums;
    using SimpleArithmeticCalculator.Interfaces;

    [TestClass]
    public class CalculatorAdditionCommandTest
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
        public void sampleTest()
        {
            //Arrange 
            double expectedValue = 5;
            calculatorCommandMock.Setup(x => x.Calculate(3, 2)).Returns(5);
            calculateCommandFactoryMock.Setup(x => x.CreateCommand(CommandType.Add)).Returns(calculatorCommandMock.Object);
           var command = calculateCommandFactory.CreateCommand(CommandType.Add);
           var value = command.Calculate(3, 2);
            //Act
            double actualValue = command.Calculate(3, 2);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);


        }
    }
}
