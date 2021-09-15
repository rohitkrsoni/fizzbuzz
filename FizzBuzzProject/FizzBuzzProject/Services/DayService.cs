using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{
    public class DayService : IDayService
    {
        public DayOfWeek GetTodayDay()
        {
            return DateTime.Today.DayOfWeek;
        }
    }
}
