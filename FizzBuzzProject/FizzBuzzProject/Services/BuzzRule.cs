namespace FizzBuzzProject.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BuzzRule : IRule
    {
        private readonly IDayService dayService;

        public BuzzRule(IDayService dayService)
        {
            this.dayService = dayService;
        }

        public string Execute()
        {
            if (dayService.GetTodayDay() == DayOfWeek.Wednesday)
            {
                return "Wuzz";
            }

            return "Buzz";
        }

        public bool IsMatch(int number)
        {
            return number % 5 == 0 && number % 3 != 0;
        }
    }
}
