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
        public IActionResult Index(FizzBuzzViewModel model)
        {
            if(ModelState.IsValid==false)
            {
                return View();
            }
            model.FizzBuzzNumbers = service.GetFizzBuzzNumbers(model.User_Input ?? 0, dayService);//setting user_Input as nullable and overriding the default errormessage when it is null by using Required attribute
            return RedirectToAction("ResultViewWithPagination", model);
        }
        public ViewResult Result(FizzBuzzViewModel fizzBuzzViewModel)
        {
            return View(fizzBuzzViewModel);
        }
        public ViewResult ResultViewWithPagination(FizzBuzzViewModel fizzBuzzViewModel,int? page)
        {
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            IQueryable<string> numbersQueryble = fizzBuzzViewModel.FizzBuzzNumbers.AsQueryable();
            IPagedList<string> PagedList = numbersQueryble.ToPagedList(pageNumber, 20); // will only contain 25 products max because of the pageSize

            ViewBag.PagedList = PagedList;
            return View(fizzBuzzViewModel);
        }
    }
}
