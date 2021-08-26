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
        private readonly FizzBuzzViewModel _fizzBuzzViewModel;

        public FizzBuzzController(IFizzBuzzService service,FizzBuzzViewModel fizzBuzzViewModel)
        {
            this.service = service;
            _fizzBuzzViewModel = fizzBuzzViewModel;
        }
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FizzBuzzViewModel model)
        {
            if(ModelState.IsValid==false)
            {
                return View();
            }
            _fizzBuzzViewModel.FizzBuzzNumbers = service.GetFizzBuzzNumbers(model.number);

            return RedirectToAction("Result", _fizzBuzzViewModel);
        }
        public ViewResult Result(FizzBuzzViewModel fizzBuzzViewModel)
        {
            return View(fizzBuzzViewModel);
        }
    }
}
