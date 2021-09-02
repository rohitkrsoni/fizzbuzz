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
    public class FizzBuzzController: Controller
    {
        private readonly IFizzBuzzService service;

        public FizzBuzzController(IFizzBuzzService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ViewResult Home()
        {
            return View("Index");
        }
        [HttpGet]
        public ViewResult Index(int User_Input, int? page)
        {

            FizzBuzzViewModel fizzBuzzViewModel = new() { User_Input = User_Input };
            fizzBuzzViewModel.FizzBuzzNumbers = 
                service.GetFizzBuzzNumbers(User_Input);
            var pageNumber = page ?? 1;
            IQueryable<string> numbersQueryble = fizzBuzzViewModel.FizzBuzzNumbers.AsQueryable();
            IPagedList<string> PagedList = numbersQueryble.ToPagedList(pageNumber, 20);
            ViewBag.PagedList = PagedList;
            return View("Index",fizzBuzzViewModel);

        }
        [HttpPost]
        public IActionResult Index(FizzBuzzViewModel fizzBuzzViewModel)
        {
            if (ModelState.IsValid == false)
            {
                return View();
            }
            return RedirectToAction("Index", new { User_Input = fizzBuzzViewModel.User_Input,page = 1 });

        }
    }
}
