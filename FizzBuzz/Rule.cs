using System;

namespace FizzBuzz
{
    public class Rule
    {
        private readonly string output;
        private readonly Func<int, bool> condition;

        /// <summary>
        /// Rule object to store the condition of the output.
        /// </summary>
        /// <param name="output">String to output when the conition is met.</param>
        /// <param name="condition">Function to define the conditions. It will return the output string if the result is true.</param>
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

}

