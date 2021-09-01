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
        private readonly IDayService dayService;

        public FizzBuzzController(IFizzBuzzService service,IDayService dayService)
        {
            this.service = service;
            this.dayService = dayService;
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
            model.FizzBuzzNumbers = service.GetFizzBuzzNumbers(model.User_Input??0,dayService);//setting user_Input as nullable and overriding the default errormessage when it is null by using Required attribute
            return View("Result", model);
        }
        public ViewResult Result(FizzBuzzViewModel fizzBuzzViewModel)
        {
            return View(fizzBuzzViewModel);
        }
    }
}
