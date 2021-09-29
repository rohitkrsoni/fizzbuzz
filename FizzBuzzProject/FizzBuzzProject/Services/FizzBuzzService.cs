namespace FizzBuzzProject.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IEnumerable<IRule> rules;

        public FizzBuzzService(IEnumerable<IRule> rules)
        {
            this.rules = rules;
        }

        public IEnumerable<string> GetFizzBuzzNumbers(int input)
        {
            var fizzBuzzNumbers = new List<string>();
            for (var i = 1; i <= input; i++)
            {
                var applicableRules = rules.FirstOrDefault(x => x.IsMatch(i));
                var fizzBuzzNumber = applicableRules != null ? applicableRules.Execute() : i.ToString();
                yield return fizzBuzzNumber;
            }
        }
    }
}
