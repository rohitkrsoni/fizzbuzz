namespace FizzBuzzTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FizzBuzzProject.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FizzBuzzViewModelTest
    {
        [DataTestMethod]
        [DataRow(0, false)]
        [DataRow(-1, false)]
        [DataRow(5000, false)]
        [DataRow(1, true)]

        public void FizzBuzzViewModel_Validation_Test(int numbers, bool expectations)
        {
            // Arrange
            var model = new FizzBuzzViewModel();
            var context = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();
            model.UserInput = numbers;

            // Act
            var actual = Validator.TryValidateObject(model, context, results, true);

            // Assert
            Assert.IsTrue(expectations == actual);
        }
    }
}
