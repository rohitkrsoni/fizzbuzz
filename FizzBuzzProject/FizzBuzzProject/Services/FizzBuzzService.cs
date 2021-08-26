﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IList<IRule> rules;

        public FizzBuzzService()
        {
            rules = new List<IRule>
            {
                new FizzRule(),
                new BuzzRule(),
                new FizzBuzzRule()
            };
        }
        public IList<string> GetFizzBuzzNumbers(int input)
        {
            var fizzBuzzNumbers = new List<string>();
            for(var i = 1; i <=input; i++)
            {
                var applicableRules = rules.FirstOrDefault(x => x.IsMatch(i));
                var fizzBuzzNumber = applicableRules != null ? applicableRules.Execute() : i.ToString();
                fizzBuzzNumbers.Add(fizzBuzzNumber);
            }
            return fizzBuzzNumbers;
        }
    }
}