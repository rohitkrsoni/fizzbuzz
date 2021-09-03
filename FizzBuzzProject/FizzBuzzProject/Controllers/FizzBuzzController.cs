using FizzBuzzProject.Models;
using FizzBuzzProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace FizzBuzzProject.Controllers
{
    public class FizzBuzzController : Controller
    {
        private readonly IFizzBuzzService service;

        public FizzBuzzController(IFizzBuzzService service)
        {
            this.service = service;
        }


        [HttpGet]
        public ViewResult Index(int UserInput, int? page)
        {
            if (UserInput == 0) return View();
            FizzBuzzViewModel fizzBuzzViewModel = new() { UserInput = UserInput };
            var numbers =
                service.GetFizzBuzzNumbers(UserInput);
            var pageNumber = page ?? 1;
            fizzBuzzViewModel.FizzBuzzNumbers = numbers.ToPagedList(pageNumber, 20);
            return View("Index", fizzBuzzViewModel);

        }
        [HttpPost]
        public IActionResult Index(FizzBuzzViewModel fizzBuzzViewModel)
        {
            if (ModelState.IsValid == false)
            {
                return View();
            }
            return RedirectToAction("Index", new { fizzBuzzViewModel.UserInput, page = 1 });

        }
    }
}
