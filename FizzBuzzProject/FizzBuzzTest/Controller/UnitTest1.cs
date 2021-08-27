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
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            mockService.Setup(x => x.GetFizzBuzzNumbers(1)).Returns(new List<string> { "1" });
            var controller = new FizzBuzzController(mockService.Object);
            var expected = new FizzBuzzViewModel { FizzBuzzNumbers = new List<string> { "1" }, number = 1 };


            //Act
            ViewResult actualResult = controller.Index(new FizzBuzzViewModel { number = 1});
            var ActualModel = (FizzBuzzViewModel)actualResult.Model;

            //Assert

            Assert.AreEqual(actualResult.ViewName, "Result");
            Assert.AreEqual<int>(ActualModel.number, expected.number);
            CollectionAssert.AreEqual((List<string>)ActualModel.FizzBuzzNumbers, (List<string>)expected.FizzBuzzNumbers);
            
            mockService.Verify(x => x.GetFizzBuzzNumbers(It.IsAny<int>()), Times.Once);
        }

        
    }
}
