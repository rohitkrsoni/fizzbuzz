﻿namespace FizzBuzzProject.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class FizzBuzzRule : IRule
    {
        public string Execute()
        {
            return "FizzBuzz";
        }

        public bool IsMatch(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }
    }
}
