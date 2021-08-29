using FizzBuzzProject.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest.Service
{
    [TestClass]
    public class FizzBuzzRuleTest
    {

        public Mock<IRule> mockService;
        [TestMethod]
        public void WhetherFizzBuxxRuleProvidesExpectedOutput_Multipleof_3and5_Passing()
        {

            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 3 == 0&&i%5==0))).Returns(true);
            mockService.Setup(x => x.Execute()).Returns("FizzBuzz");

            //Act
            string actual = null;
            int input = 15;//Enter input which is divisible by both 3 and 5
            if (mockService.Object.IsMatch(input))
            {
                actual = mockService.Object.Execute();
            }
            else
            {
                actual = input.ToString();
            }


            //Assert
            Assert.AreEqual(actual, "FizzBuzz");
            mockService.Verify(x => x.IsMatch(It.IsAny<int>()), Times.Once);
            mockService.Verify(x => x.Execute(), Times.Once);


        }
        [TestMethod]
        public void WhetherFizzRuleProvidesExpectedOutput_NonMultipleOf_3or5_Failing()
        {

            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 3 == 0 && i % 5 == 0))).Returns(true);
            mockService.Setup(x => x.Execute()).Returns("FizzBuzz");

            //Act
            string actual = null;
            int input = 20;//Enter input which is not divisible by 3 or 5
            if (mockService.Object.IsMatch(input))
            {
                actual = mockService.Object.Execute();
            }
            else
            {
                actual = input.ToString();
            }


            //Assert
            Assert.AreNotEqual(actual, "FizzBuzz");//Passes if FizzBuzz is not returned
            mockService.Verify(x => x.IsMatch(It.IsAny<int>()), Times.Once);
            mockService.Verify(x => x.Execute(), Times.Never);


        }
    }
}
