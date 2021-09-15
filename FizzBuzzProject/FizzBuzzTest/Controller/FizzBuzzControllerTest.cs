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
        public void indexGetTest()
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            var controller = new FizzBuzzController(mockService.Object);


            //Act
            ViewResult actualResult = controller.Index();

            //Assert
            Assert.AreEqual("Index", actualResult.ViewName);

        }

        [DataTestMethod]
        [DataRow(10, "PageImplement")]
        [DataRow(20, "PageImplement")]
        public void Whether_Index_GetPost_Method_Provides_Expected_Output_for_Valid_ModelState(int numbers, String expectations)
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            var controller = new FizzBuzzController(mockService.Object);
            controller.ModelState.Clear();

            //Act
            var actualResult = (RedirectToActionResult)controller.Index(new FizzBuzzViewModel { UserInput = numbers });

            //Assert
            Assert.AreEqual(expectations, actualResult.ActionName);



        }

        [DataTestMethod]
        [DataRow(0, "Index")]
        [DataRow(5000, "Index")]
        [DataRow(-1, "Index")]
        public void Whether_Index_GetPost_Method_Provides_Expected_Output_for_InValid_ModelState(int numbers, String expectations)
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            var controller = new FizzBuzzController(mockService.Object);
            controller.ModelState.AddModelError("test", "test");

            //Act
            var actualResult = controller.Index(new FizzBuzzViewModel { UserInput = numbers }) as ViewResult;

            //Assert
            Assert.AreEqual(expectations, actualResult.ViewName);



        }
        [DataTestMethod]
        [DataRow(5, 1,new string[] {"1","2","3","4","5"})]
        [DataRow(25,2,new string[] { "21","22","23","24","25"})]
        public void rest(int numbers,int page,string[] expectations)
        {
            //Arrange
            var mockService = new Mock<IFizzBuzzService>();
            var FizzBuzzNumbers = new List<String>();
            for (int number = 1; number <= numbers; number++)
            {
                FizzBuzzNumbers.Add(number.ToString());
            }
            mockService.Setup(x => x.GetFizzBuzzNumbers(It.IsAny<int>())).Returns(FizzBuzzNumbers);
            var controller = new FizzBuzzController(mockService.Object);

            //Act
            ViewResult actualResult = controller.PageImplement(1,page);
            var actualModel = actualResult.Model as FizzBuzzViewModel;

            //Assert
            Assert.AreEqual("Index", actualResult.ViewName);
            CollectionAssert.AreEqual(actualModel.FizzBuzzNumbers.ToList(), new List<string>(expectations));

        }

    }
}
