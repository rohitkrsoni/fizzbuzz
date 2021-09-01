using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{
    public class DayService : IDayService
    {
        public int GetTodayDay()
        {
            return (int)DateTime.Today.DayOfWeek;
        }
    }
}
