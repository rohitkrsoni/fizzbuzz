using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{
    public interface IRule
    {
        bool IsMatch(int number);
        string Execute();
    }
}
