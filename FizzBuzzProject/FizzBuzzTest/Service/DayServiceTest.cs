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
            var dayService = new DayService();

            //Act
            DayOfWeek actual = dayService.GetTodayDay();
            DayOfWeek expected = DateTime.Today.DayOfWeek;

            //Assert
            Assert.AreEqual(expected, actual);
        }
       
    }
}
