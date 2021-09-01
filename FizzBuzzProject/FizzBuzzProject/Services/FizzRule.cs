using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{

    public class FizzRule : IRule
    {
        public string Execute(IDayService dayService)
        {   
            if(dayService.GetTodayDay()!=3)
            return "Fizz";
            return "Wizz";
        }

        public bool IsMatch(int number)
        {
            return number % 3 == 0;
        }

        

        
    }
}
