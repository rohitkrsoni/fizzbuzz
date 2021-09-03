using FizzBuzzProject.Controllers;
using FizzBuzzProject.Models;
using FizzBuzzProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzControllerTest
    {
        [TestMethod]
        public void Whether_Model_IsUpdated_With_Expected_FizzBuzzNumbers_InputIs1()
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            mockService.Setup(x => x.GetFizzBuzzNumbers(It.IsAny<int>())).Returns(new List<string> { "1" });
            var controller = new FizzBuzzController(mockService.Object);


            //Act
            ViewResult actualResult = controller.Index(1, null);
            var ActualModel = (FizzBuzzViewModel)actualResult.Model;
            var numbers = ActualModel.FizzBuzzNumbers.ToList();

            //Assert

            Assert.AreEqual("Index", actualResult.ViewName);
            CollectionAssert.AreEqual(numbers, (new List<string> { "1" }));

            mockService.Verify(x => x.GetFizzBuzzNumbers(It.IsAny<int>()), Times.Once);
        }
        [TestMethod]
        public void Whether_Model_Is_Updated_With_Expwcted_FizzBuzzNumbers_InputIs6()
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            mockService.Setup(x => x.GetFizzBuzzNumbers(6)).Returns(new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz" });
            var controller = new FizzBuzzController(mockService.Object);


            //Act
            ViewResult actualResult = controller.Index(6, null);
            var ActualModel = (FizzBuzzViewModel)actualResult.Model;
            var numbers = ActualModel.FizzBuzzNumbers.ToList();

            //Assert

            Assert.AreEqual("Index", actualResult.ViewName);
            CollectionAssert.AreEqual(numbers, new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz" });

            mockService.Verify(x => x.GetFizzBuzzNumbers(It.IsAny<int>()), Times.Once);
        }




    }
}
