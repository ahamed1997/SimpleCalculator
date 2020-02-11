using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimpleArithmeticCalculator.Interfaces;
using System;

namespace SimpleArithmeticCalculatorTests
{
    [TestClass]
    public class SubtractionCommandTests
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
        public void SubtractionCommand_Test()
        {
            //Arrange
            double expectedValue = 16;
            try
            {
                //Act
                this.calculatorMock.Setup(x => x.Calculate(103, 87)).Returns(16);
                double actualValue = calculator.Calculate(103, 87);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch
            {
                throw;
            }
        }

        //[ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void SubtractionCommandTest_withPositiveResult()
        {
            //Arrange
            double expectedValue = 59.7;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(80, -20.3)).Returns(59.7);
                double actualValue = calculator.Calculate(80, -20.3);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //[ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void SubtractionCommandTest_withNegativeResult()
        {
            //Arrange
            double expectedValue = -40.19;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(-52.31,12.12)).Returns(-40.19);
                double actualValue = calculator.Calculate(-52.31, 12.12);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        // [ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void SubtractionCommandTest_withDecimalNegativeResult()
        {
            //Arrange
            double expectedValue = -0.44;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(-0.75,0.31)).Returns(-0.44);
                double actualValue = calculator.Calculate(-0.75, 0.31);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
