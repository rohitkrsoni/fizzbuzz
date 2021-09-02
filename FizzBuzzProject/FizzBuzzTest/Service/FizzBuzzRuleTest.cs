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
        public Mock<IDayService> mockDayService;

        [TestMethod]
        public void Whether_IsMatch_Provides_Expected_Value_Multiples_Of_15()
        {
            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 15 == 0))).Returns(true);


            //Act
            bool actual = mockService.Object.IsMatch(30);

            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Whether_IsMatch_Provides_Expected_Value_Non_Multiples_Of_15()
        {
            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 15 == 0))).Returns(true);


            //Act
            bool actual = mockService.Object.IsMatch(5);

            //Assert
            Assert.IsTrue(!actual);
        }
        [TestMethod]
        public void Whether_Execute_Provides_Expected_Value()
        {
            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.Execute()).Returns("FizzBuzz");


            //Act
            string actual = mockService.Object.Execute();

            //Assert
            Assert.AreEqual(actual, "FizzBuzz");
        }
    }
}
