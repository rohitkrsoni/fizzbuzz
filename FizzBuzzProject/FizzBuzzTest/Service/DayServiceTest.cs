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
        public void Whether_GetTodayDay_Provides_Expected_Value()
        {
            //Arrange
            var mockService = new Mock<IDayService>();
            mockService.Setup(x => x.GetTodayDay()).Returns((int)DateTime.Today.DayOfWeek);
            int expected = 3;

            //Act
            int actual = mockService.Object.GetTodayDay();

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
