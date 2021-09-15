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

        [DataTestMethod]
        [DataRow(DayOfWeek.Wednesday,"Wuzz")]
        [DataRow(DayOfWeek.Monday,"Buzz")]
        public void Whether_Execute_Provides_Expected_Output(DayOfWeek dayOfWeek, string expectations)
        {
            //Arrange
            var mockDayService = new Mock<IDayService>();
            mockDayService.Setup(x => x.GetTodayDay()).Returns(dayOfWeek);
            var rule = new BuzzRule(mockDayService.Object);

            //Act
            string actual = rule.Execute();

            //Assert
            Assert.AreEqual(actual, expectations);
        }
        [DataTestMethod]
        [DataRow(1, false)]
        [DataRow(3, false)]
        [DataRow(5, true)]
        [DataRow(15, false)]
        public void Whether_IsMatch_Provides_Expected_Output(int numbers,bool expectations)
        {
            //Arrange
            var mockDayService = new Mock<IDayService>();
            var rule = new BuzzRule(mockDayService.Object);

            //Act
            bool actual = rule.IsMatch(numbers);

            //Assert
            Assert.IsTrue(expectations== actual);

        }


    }
}
