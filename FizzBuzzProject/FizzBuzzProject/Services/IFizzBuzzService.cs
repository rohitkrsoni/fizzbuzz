using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{
    public interface IFizzBuzzService
    {
        IList<string> GetFizzBuzzNumbers(int user_Input);
    }
}
