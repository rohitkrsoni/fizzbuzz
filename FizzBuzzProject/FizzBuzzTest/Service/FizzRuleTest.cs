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
    public class FizzRuleTest
    {
        public Mock<IRule> mockService;
        [TestMethod]
        public void WhetherFizzRuleProvidesExpectedOutput_ForInputMultipleOf_3_Passing()
        {

            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i=>i%3==0))).Returns(true);
            mockService.Setup(x => x.Execute()).Returns("Fizz");

            //Act
            string actual=null;
            int input = 3;
            if (mockService.Object.IsMatch(input)) {
                 actual = mockService.Object.Execute();
            }
            else
            {
                actual = input.ToString();
            }


            //Assert
            Assert.AreEqual(actual, "Fizz");
            mockService.Verify(x => x.IsMatch(It.IsAny<int>()), Times.Once);
            mockService.Verify(x => x.Execute(), Times.Once);


        }
        [TestMethod]
        public void WhetherFizzRuleProvidesExpectedOutput_ForInputNotMultipleOf_3_Passing_Failing()
        {

            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 3 == 0))).Returns(true);
            mockService.Setup(x => x.Execute()).Returns("Fizz");

            //Act
            string actual = null;
            int input = 10;//Enter input which is not divisible by 3
            if (mockService.Object.IsMatch(input))
            {
                actual = mockService.Object.Execute();
            }
            else
            {
                actual = input.ToString();
            }


            //Assert
            Assert.AreNotEqual(actual, "Fizz");//Passes if Fizz is not Returned.
            mockService.Verify(x => x.IsMatch(It.IsAny<int>()), Times.Once);
            mockService.Verify(x => x.Execute(), Times.Never);


        }


    }
}
