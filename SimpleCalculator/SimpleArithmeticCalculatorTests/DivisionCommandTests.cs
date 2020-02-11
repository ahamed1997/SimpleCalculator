using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimpleArithmeticCalculator.Interfaces;
using System;

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
        public void DivisionCommandTest()
        {
            //Arrange
            double expectedValue = 41;
            try
            {
                //Act
                this.calculatorMock.Setup(x => x.Calculate(82, 2)).Returns(41);
                double actualValue = calculator.Calculate(82, 2);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch
            {
                throw;
            }
        }
        //[ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void DivisionCommandTest_withTwoPositiveIntegerwithDecimal()
        {
            //Arrange
            double expectedValue = 0.6073;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(0.75,1.235)).Returns(0.6073);
                double actualValue = calculator.Calculate(0.75, 1.235);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //[ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void DivisionCommandTest_withOnenegativeandOnepositiveInteger()
        {
            //Arrange
            double expectedValue = -4;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(80,-20)).Returns(-4);
                double actualValue = calculator.Calculate(80, -20);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        // [ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void DivisionCommandTest_withTwoNegativeIntegers()
        {
            //Arrange
            double expectedValue = 0.5;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(-1,-2)).Returns(0.5);
                double actualValue = calculator.Calculate(-1,-2);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        // [ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void DivisionCommandTest_DivideByZero()
        {
            //Arrange
            double expectedValue = 0;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(8,0)).Returns(0);
                double actualValue = calculator.Calculate(8,0);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        // [ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void DivisionCommandTest_DivideZeroByAnyNumber()
        {
            //Arrange
            double expectedValue = 0;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(0,30)).Returns(0);
                double actualValue = calculator.Calculate(0, 30);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
