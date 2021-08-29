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
    public class BuzzRuleTest
    {
        public Mock<IRule> mockService;
        [TestMethod]
        public void WhetherBuzzRuleProvidesExpectedOutput_ForMultiplesOf5_Passing()
        {

            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 5 == 0))).Returns(true);
            mockService.Setup(x => x.Execute()).Returns("Buzz");

            //Act
            string actual = null;
            int input = 5;//Enter input which is divisible by 5
            if (mockService.Object.IsMatch(input))
            {
                actual = mockService.Object.Execute();
            }
            else
            {
                actual = input.ToString();
            }


            //Assert
            Assert.AreEqual(actual, "Buzz");
            mockService.Verify(x => x.IsMatch(It.IsAny<int>()), Times.Once);
            mockService.Verify(x => x.Execute(), Times.Once);


        }
        [TestMethod]
        public void WhetherFizzRuleProvidesExpectedOutput_ForNonMultiplesOf5_Failing()
        {

            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 5 == 0))).Returns(true);
            mockService.Setup(x => x.Execute()).Returns("Buzz");

            //Act
            string actual = null;
            int input = 11;//Enter input which is not divisible by 5
            if (mockService.Object.IsMatch(input))
            {
                actual = mockService.Object.Execute();
            }
            else
            {
                actual = input.ToString();
            }


            //Assert
            Assert.AreNotEqual(actual, "Buzz");//Passes if Buzz is not returned
            mockService.Verify(x => x.IsMatch(It.IsAny<int>()), Times.Once);
            mockService.Verify(x => x.Execute(), Times.Never);


        }


    }
}
