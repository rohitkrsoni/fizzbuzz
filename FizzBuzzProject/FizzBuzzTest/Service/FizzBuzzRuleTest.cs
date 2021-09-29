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
    public class FizzBuzzRuleTest
    {
        [DataTestMethod]
        [DataRow(1, false)]
        [DataRow(3, false)]
        [DataRow(5, false)]
        [DataRow(15, true)]
        public void Whether_IsMatch_Provides_Expected_Output(int numbers, bool expectaions)
        {
            // Arrange
            var rule = new FizzBuzzRule();

            // Act
            bool actual = rule.IsMatch(numbers);

            // Assert
            Assert.IsTrue(actual == expectaions);
        }

        [TestMethod]
        public void Whether_Execute_Provides_Expected_Value()
        {
            // Arrange
            var rule = new FizzBuzzRule();

            // Act
            string actual = rule.Execute();

            // Assert
            Assert.AreEqual(actual, "FizzBuzz");
        }
    }
}
