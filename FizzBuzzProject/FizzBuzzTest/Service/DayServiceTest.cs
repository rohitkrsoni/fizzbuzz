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
    public class DayServiceTest
    {
        [TestMethod]
        public void Whether_GetTodayDay_Provides_Expected_Value_For_Wednesday()
        {
            //Arrange
            var mockService = new Mock<IDayService>();
            mockService.Setup(x => x.GetTodayDay()).Returns((int)DayOfWeek.Wednesday);
            int expected = 3;

            //Act
            int actual = mockService.Object.GetTodayDay();

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Whether_GetTodayDay_Provides_Expected_Value_For_Non_Wednesday()
        {
            //Arrange
            var mockService = new Mock<IDayService>();
            mockService.Setup(x => x.GetTodayDay()).Returns((int)DayOfWeek.Monday);
            int notExpected = 3;

            //Act
            int actual = mockService.Object.GetTodayDay();

            //Assert
            Assert.AreNotEqual(actual, notExpected);
        }
    }
}
