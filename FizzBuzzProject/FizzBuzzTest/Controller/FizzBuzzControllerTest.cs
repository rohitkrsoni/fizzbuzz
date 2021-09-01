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
        public void Whether_Model_Is_Updated_With_Expected_FizzBuzzNumbers_InputIs1()
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            var mockDayService = new Mock<IDayService>();
            mockService.Setup(x => x.GetFizzBuzzNumbers(It.IsAny<int>(),mockDayService.Object)).Returns(new List<string> { "1" });
            Console.WriteLine(mockService.Object.GetType());
            var controller = new FizzBuzzController(mockService.Object,mockDayService.Object);


            //Act
            ViewResult actualResult = controller.Index(new FizzBuzzViewModel { User_Input = 1});
            var ActualModel = (FizzBuzzViewModel)actualResult.Model;

            //Assert

            Assert.AreEqual(actualResult.ViewName, "Result");
            CollectionAssert.AreEqual((List<string>)ActualModel.FizzBuzzNumbers, (new List<string> { "1" }));
            
            mockService.Verify(x => x.GetFizzBuzzNumbers(It.IsAny<int>(),mockDayService.Object), Times.Once);
        }
        [TestMethod]
        public void Whether_Model_Is_Updated_With_Expected_FizzBuzzNumbers_InputIs6()
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            var mockDayService = new Mock<IDayService>();
            mockService.Setup(x => x.GetFizzBuzzNumbers(6,mockDayService.Object)).Returns(new List<string> { "1","2","Fizz","4","Buzz","Fizz" });
            Console.WriteLine(mockService.Object.GetType());
            var controller = new FizzBuzzController(mockService.Object, mockDayService.Object);


            //Act
            ViewResult actualResult = controller.Index(new FizzBuzzViewModel { User_Input = 6 });
            var ActualModel = (FizzBuzzViewModel)actualResult.Model;

            //Assert

            Assert.AreEqual(actualResult.ViewName, "Result");
            CollectionAssert.AreEqual((List<string>)ActualModel.FizzBuzzNumbers, (new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz" }));

            mockService.Verify(x => x.GetFizzBuzzNumbers(It.IsAny<int>(),mockDayService.Object), Times.Once);
        }




    }
}
