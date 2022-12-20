using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzEngine
    {
        private readonly List<Rule> rules = new List<Rule>();

        public void AddRule(Rule rule)
        {
            rules.Add(rule);
        }

        public void Run(int limit = 100)
        {
            for (int i = 1; i <= limit; i++)
            {
                string output = "";

                foreach (var rule in rules)
                {
                    output += rule.Evaluate(i);
                }
                if (string.IsNullOrEmpty(output))
                {
                    output = i.ToString();
                }

                Console.WriteLine($"{i}: {output}");
            }
        }
    }

}

