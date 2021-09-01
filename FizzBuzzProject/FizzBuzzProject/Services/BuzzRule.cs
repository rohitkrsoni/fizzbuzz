using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{
    public class BuzzRule : IRule
    {
        public string Execute(IDayService dayService)
        {
            if (dayService.GetTodayDay()!=3)
                return "Buzz";
            return "Wuzz";
        }

        public bool IsMatch(int number)
        {
            return (number % 5 == 0);
        }

        
    }
}
