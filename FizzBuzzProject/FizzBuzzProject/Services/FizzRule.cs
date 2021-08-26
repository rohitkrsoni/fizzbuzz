using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{
    public class FizzRule : IRule
    {
        public string Execute()
        {
            return "Fizz";
        }

        public bool IsMatch(int number)
        {
            return number % 3 == 0;
        }
    }
}
