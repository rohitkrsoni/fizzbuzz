namespace FizzBuzzProject.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using FizzBuzzProject.Models;
    using FizzBuzzProject.Services;
    using Microsoft.AspNetCore.Mvc;
    using X.PagedList;

    public class FizzBuzzController : Controller
    {
        private readonly IFizzBuzzService service;

        public FizzBuzzController(IFizzBuzzService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FizzBuzzViewModel fizzBuzzViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            return RedirectToAction("GetFizzBuzzNumbersUsingPages", new { fizzBuzzViewModel.UserInput });
        }

        [HttpGet]
        public ViewResult GetFizzBuzzNumbersUsingPages(int userInput, int? page)
        {
            FizzBuzzViewModel fizzBuzzViewModel = new () { UserInput = userInput };
            var numbers =
                service.GetFizzBuzzNumbers(userInput);
            var pageNumber = page ?? 1;
            fizzBuzzViewModel.FizzBuzzNumbers = numbers.ToPagedList(pageNumber, 20);
            return View("Index", fizzBuzzViewModel);
        }
    }
}

// My Notes:
// IEnumerable can be directly converted to PagedList
// Yield can be implemented only with the IEnumerable<> return type.