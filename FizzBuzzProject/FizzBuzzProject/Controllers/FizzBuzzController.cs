using FizzBuzzProject.Models;
using FizzBuzzProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Controllers
{
    public class FizzBuzzController: Controller
    {
        private readonly IFizzBuzzService service;

        public FizzBuzzController(IFizzBuzzService service)
        {
            this.service = service;
        }
        
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(FizzBuzzViewModel model)
        {
            if(ModelState.IsValid==false)
            {
                return View();
            }
            model.FizzBuzzNumbers = service.GetFizzBuzzNumbers(model.number);
            return View("Result", model);
        }
        public ViewResult Result(FizzBuzzViewModel fizzBuzzViewModel)
        {
            return View(fizzBuzzViewModel);
        }
    }
}
