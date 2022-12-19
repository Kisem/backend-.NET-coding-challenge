using System;
using System.Collections.Generic;

/**
 *
 * Given is the following FizzBuzz application which counts from 1 to 100 and outputs either the corresponding
 * number or the corresponding text if one of the following rules apply.
 * Rules:
 *  - dividable by 3 without a remainder -> Fizz
 *  - dividable by 5 without a remainder -> Buzz
 *  - dividable by 3 and 5 without a remainder -> FizzBuzz
 *
 * ACCEPTANCE CRITERIA:
 * Please refactor this code so that it can be easily extended in the future with other rules, such as
 * "if it is dividable by 7 without a remainder output Bar"
 * "if multiplied by 10 is larger than 100 output Foo"
 *
 */

namespace FizzBuzz
{
    public class Rule
    {
        private string output;
        private Func<int, bool> condition;

        public Rule(string output, Func<int, bool> condition)
        {
            this.output = output;
            this.condition = condition;
        }

        public string Evaluate(int operand)
        {
            if (this.condition(operand))
            {
                return this.output;
            }
            return null;
        }
    }

    public class FizzBuzzEngine
    {
        private List<Rule> rules = new List<Rule>();

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

    public class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzzEngine engine = new FizzBuzzEngine();

            engine.AddRule(new Rule("Fizz", (n) => { return n % 3 == 0; }));
            engine.AddRule(new Rule("Buzz", (n) => { return n % 5 == 0; }));

            engine.AddRule(new Rule("Bar", (n) => { return n % 7 == 0; }));
            engine.AddRule(new Rule("Foo", (n) => { return n * 10 > 100; }));

            engine.Run(100);
            Console.ReadKey();
        }
    }
}
