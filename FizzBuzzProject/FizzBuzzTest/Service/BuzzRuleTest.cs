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
        public Mock<IDayService> mockDayService;

        [TestMethod]
        public void Whether_IsMatch_Provides_Expected_Value_Multiples_Of_5()
        {
            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 5 == 0))).Returns(true);


            //Act
            bool actual = mockService.Object.IsMatch(5);

            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Whether_IsMatch_Provides_Expected_Value_Non_Multiples_Of_5()
        {
            //Arrange
            var mockService = new Mock<IRule>();
            mockService.Setup(x => x.IsMatch(It.Is<int>(i => i % 5 == 0))).Returns(true);


            //Act
            bool actual = mockService.Object.IsMatch(3);

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
            mockService.Setup(x => x.Execute(It.Is<IDayService>(x => x.GetTodayDay() == 3))).Returns("Wuzz");


            //Act
            string actual = mockService.Object.Execute(mockDayService.Object);

            //Assert
            Assert.AreEqual(actual, "Wuzz");
        }
        [TestMethod]
        public void Whether_Execute_Provides_Expected_Value_For_Non_Wednesday()
        {
            //Arrange
            var mockService = new Mock<IRule>();
            var mockDayService = new Mock<IDayService>();
            mockDayService.Setup(x => x.GetTodayDay()).Returns(4);
            mockService.Setup(x => x.Execute(It.Is<IDayService>(x => x.GetTodayDay() != 3))).Returns("Buzz");


            //Act
            string actual = mockService.Object.Execute(mockDayService.Object);

            //Assert
            Assert.AreEqual(actual, "Buzz");
        }


    }
}
