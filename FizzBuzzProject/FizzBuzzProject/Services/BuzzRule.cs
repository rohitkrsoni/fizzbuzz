using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{
    public class BuzzRule : IRule
    {
        public IDayService DayService;
        public BuzzRule(IDayService DayService)
        {
            this.DayService = DayService;
        }
        public string Execute()
        {
            if (DayService.GetTodayDay() == DayOfWeek.Wednesday)
                return "Wuzz";
            return "Buzz";
        }

        public bool IsMatch(int number)
        {
            return (number % 5 == 0&& number%3!=0);
        }
    }
}
