﻿namespace FizzBuzzProject.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IFizzBuzzService
    {
        IEnumerable<string> GetFizzBuzzNumbers(int user_Input);
    }
}
