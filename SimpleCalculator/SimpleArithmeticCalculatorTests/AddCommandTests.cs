using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimpleArithmeticCalculator.Interfaces;

namespace SimpleArithmeticCalculatorTests
{
    [TestClass]
    public class AddCommandTests
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
        public void AddCommand_Tests()
        {
            //Arrange
            double expectedValue = 4;
            this.calculatorMock.Setup(x => x.Calculate(2, 2)).Returns(4);

            //Act
            double actualValue = calculator.Calculate(2, 2);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            this.calculatorMock.Verify(x => x.Calculate(It.IsAny<double>(), It.IsAny<double>()), Times.Once());

        }
    }
}
