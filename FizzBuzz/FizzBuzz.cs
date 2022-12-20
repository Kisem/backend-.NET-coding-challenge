using System;

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
    public class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzzEngine engine = new FizzBuzzEngine();

            engine.AddRule(new Rule("Fizz", (n) => { return n % 3 == 0; }));
            engine.AddRule(new Rule("Buzz", (n) => { return n % 5 == 0; }));

            // Example extensions
            engine.AddRule(new Rule("Bar", (n) => { return n % 7 == 0; }));
            engine.AddRule(new Rule("Foo", (n) => { return n * 10 > 100; }));

            engine.Run();
            Console.ReadKey();
        }
    }
}
