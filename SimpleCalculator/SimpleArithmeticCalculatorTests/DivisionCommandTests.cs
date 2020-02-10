using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimpleArithmeticCalculator.Interfaces;

namespace SimpleArithmeticCalculatorTests
{
    [TestClass]
     public class DivisionCommandTests
    {
        private Mock<ICalculatorCommand> calculatorMock;
        private ICalculatorCommand calculator;
        [TestInitialize]
        public void TestInitialize()
        {
            calculatorMock = new Mock<ICalculatorCommand>();
            calculator = calculatorMock.Object;
        }
        [TestMethod]
        public void DivisionCommand_Test()
        {

            //Arrange
            double expectedValue = 5;
            this.calculatorMock.Setup(x => x.Calculate(25, 5)).Returns(5);

            //Act
            double actualValue = calculator.Calculate(25, 5);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            this.calculatorMock.Verify(x => x.Calculate(It.IsAny<double>(), It.IsAny<double>()), Times.Once());

        }

    }
}
