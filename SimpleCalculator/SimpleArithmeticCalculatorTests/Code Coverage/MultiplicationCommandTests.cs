using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimpleArithmeticCalculator.Interfaces;
using System;

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
            double expectedValue = 400;
            try
            {
                //Act
                this.calculatorMock.Setup(x => x.Calculate(20, 20)).Returns(400);
                double actualValue = calculator.Calculate(20, 20);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        //[ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void MultiplicationCommandTest_withTwoNegativeInteger()
        {
            //Arrange
            double expectedValue = 160;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(40, 40)).Returns(160);
                double actualValue = calculator.Calculate(40,40);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //[ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void MultiplicationCommandTest_withOnenegativeandOnepositiveInteger()
        {
            //Arrange
            double expectedValue = -1343.16;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(16.57,81.06)).Returns(-1343.16);
                double actualValue = calculator.Calculate(16.57, 81.06);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        // [ExpectedException(typeof(AssertFailedException))]
        [TestMethod]
        public void MultiplicationCommandTest_withDecimalPositiveInteger()
        {
            //Arrange
            double expectedValue = 0.202;
            //Act
            try
            {
                this.calculatorMock.Setup(x => x.Calculate(0.132,1.53)).Returns(0.202);
                double actualValue = calculator.Calculate(0.132, 1.53);
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
