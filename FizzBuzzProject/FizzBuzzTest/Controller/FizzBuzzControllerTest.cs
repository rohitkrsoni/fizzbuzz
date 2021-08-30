using FizzBuzzProject.Controllers;
using FizzBuzzProject.Models;
using FizzBuzzProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzControllerTest
    {
        [TestMethod]
        public void WhetherModelIsUpdatedWithExpwctedFizzBuzzNumbers_InputIs1()
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            mockService.Setup(x => x.GetFizzBuzzNumbers(It.IsAny<int>())).Returns(new List<string> { "1" });
            Console.WriteLine(mockService.Object.GetType());
            var controller = new FizzBuzzController(mockService.Object);


            //Act
            ViewResult actualResult = controller.Index(new FizzBuzzViewModel { User_Input = 1});
            var ActualModel = (FizzBuzzViewModel)actualResult.Model;

            //Assert

            Assert.AreEqual(actualResult.ViewName, "Result");
            CollectionAssert.AreEqual((List<string>)ActualModel.FizzBuzzNumbers, (new List<string> { "1" }));
            
            mockService.Verify(x => x.GetFizzBuzzNumbers(It.IsAny<int>()), Times.Once);
        }
        [TestMethod]
        public void WhetherModelIsUpdatedWithExpwctedFizzBuzzNumbers_InputIs6()
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            mockService.Setup(x => x.GetFizzBuzzNumbers(6)).Returns(new List<string> { "1","2","Fizz","4","Buzz","Fizz" });
            Console.WriteLine(mockService.Object.GetType());
            var controller = new FizzBuzzController(mockService.Object);


            //Act
            ViewResult actualResult = controller.Index(new FizzBuzzViewModel { User_Input = 6 });
            var ActualModel = (FizzBuzzViewModel)actualResult.Model;

            //Assert

            Assert.AreEqual(actualResult.ViewName, "Result");
            CollectionAssert.AreEqual((List<string>)ActualModel.FizzBuzzNumbers, (new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz" }));

            mockService.Verify(x => x.GetFizzBuzzNumbers(It.IsAny<int>()), Times.Once);
        }




    }
}
