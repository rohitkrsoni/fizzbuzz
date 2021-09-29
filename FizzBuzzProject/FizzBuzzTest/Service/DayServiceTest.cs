namespace FizzBuzzTest.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FizzBuzzProject.Services;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class DayServiceTest
    {
        [TestMethod]
        public void Whether_GetTodayDay_Provides_Expected_Value()
        {
            // Arrange
            var dayService = new DayService();
            DayOfWeek expected = DateTime.Today.DayOfWeek;

            // Act
            DayOfWeek actual = dayService.GetTodayDay();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
