using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{
    public class FizzRule : IRule
    {
        public IDayService DayService;
        public FizzRule(IDayService DayService)
        {
            this.DayService = DayService;
        }

        public string Execute()
        {
            if (DayService.GetTodayDay() == DayOfWeek.Wednesday)
                return "Wizz";
            return "Fizz";
        }

        public bool IsMatch(int number)
        {
            return number % 3 == 0&& number%5!=0;
        }
    }
}
