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
        public Mock<IDayService> mockDayService;

        [TestMethod]
        public void Whether_IsMatch_Provides_Expected_Value_Multiples_Of_3()
        {
            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 3 == 0))).Returns(true);


            //Act
            bool actual = mockService.Object.IsMatch(3);

            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Whether_IsMatch_Provides_Expected_Value_for_Non_Multiples_Of_3()
        {
            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 3 == 0))).Returns(true);


            //Act
            bool actual = mockService.Object.IsMatch(5);

            //Assert
            Assert.IsTrue(!actual);
        }
        [TestMethod]
        public void Whether_Execute_Provides_Expected_Value_For_Wednesday()
        {
            //Arrange
            var mockService = new Mock<IRule>();
            var mockDayService = new Mock<IDayService>();
            mockDayService.Setup(x => x.GetTodayDay()).Returns(3);
            mockService.Setup(x => x.Execute()).Returns(mockDayService.Object.GetTodayDay() != 3 ? "Fizz" : "Wizz");


            //Act
            string actual = mockService.Object.Execute();

            //Assert
            Assert.AreEqual(actual, "Wizz");
        }
        [TestMethod]
        public void Whether_Execute_Provides_Expected_Value_For_Non_Wednesday()
        {
            //Arrange
            var mockService = new Mock<IRule>();
            var mockDayService = new Mock<IDayService>();
            mockDayService.Setup(x => x.GetTodayDay()).Returns(4);
            mockService.Setup(x => x.Execute()).Returns(mockDayService.Object.GetTodayDay() != 3 ? "Fizz" : "Wizz");


            //Act
            string actual = mockService.Object.Execute();

            //Assert
            Assert.AreEqual(actual, "Fizz");
        }
    }
}
