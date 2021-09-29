namespace FizzBuzzProject.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DayService : IDayService
    {
        public DayOfWeek GetTodayDay()
        {
            return DateTime.Today.DayOfWeek;
        }
    }
}
