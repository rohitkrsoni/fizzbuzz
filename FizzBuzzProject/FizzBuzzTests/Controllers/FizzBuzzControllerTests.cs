using FizzBuzzProject.Controllers;
using FizzBuzzProject.Models;
using FizzBuzzProject.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTests.Controllers
{
    class FizzBuzzControllerTests
    {
        private Mock<IFizzBuzzService> mockService;

        public void WhetherModelsUpdatedWithExpectedFizzBuzzNumbers()
        {
            //Arrange
            this.mockService.Setup(x => x.GetFizzBuzzNumbers(It.IsAny<int>())).Returns(new List<string> { "1" });

            var controller = new FizzBuzzController(this.mockService.Object);

            //Act
            var result = controller.Index(new FizzBuzzViewModel { number = 1 });

            //Assert
            var output = result as ViewResult;
        }
    }
}
