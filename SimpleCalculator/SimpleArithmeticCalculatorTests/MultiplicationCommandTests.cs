using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimpleArithmeticCalculator.Interfaces;

namespace SimpleArithmeticCalculatorTests
{
    [TestClass]
    public class MultiplicationCommandTests
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
            public void MultiplicationCommand_Tests()
            {
                //Arrange
                double expectedValue = 24;
                this.calculatorMock.Setup(x => x.Calculate(12, 2)).Returns(24);

                //Act
                double actualValue = calculator.Calculate(12, 2);

                //Assert
                Assert.AreEqual(expectedValue, actualValue);
                this.calculatorMock.Verify(x => x.Calculate(It.IsAny<double>(), It.IsAny<double>()), Times.Once());

            }
        }
    }
