namespace FizzBuzzProject.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    public class FizzRule : IRule
    {
        private readonly IDayService dayService;

        public FizzRule(IDayService dayService)
        {
            this.dayService = dayService;
        }

        public string Execute()
        {
            if (dayService.GetTodayDay() == DayOfWeek.Wednesday)
            {
                return "Wizz";
            }

            return "Fizz";
        }

        public bool IsMatch(int number)
        {
            return number % 3 == 0 && number % 5 != 0;
        }
    }
}
