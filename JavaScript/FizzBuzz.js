"use strict";

class Rule {
  constructor(output, condition) {
    if (typeof output !== 'string') {
      throw new Error('Argument "output" must be a type of string');
    }
    if (typeof condition !== 'function') {
      throw new Error('Argument "condition" must be a type of function');
    }
    this.output = output;
    this.condition = condition;
  }

  Evaluate(operand) {
    if (this.condition(operand)) {
      return this.output;
    }
    return null;
  }
};

class FizzBuzzEngine {
  rules = [];

  AddRule(rule) {
    if (!(rule instanceof Rule)) {
      throw new Error('Argument "rule" must be a type of Rule');
    }
    this.rules.push(rule);
  }

  Run(limit = 100) {
    for (let i = 1; i <= limit; i++) {

      let output = "";

      for (const rule of this.rules) {
        output += rule.Evaluate(i) ?? "";
      }

      if (!output) {
        output = i;
      }

      console.log(`${i}: ${output}`);
    }
  }
}

console.clear();

const engine = new FizzBuzzEngine();

engine.AddRule(new Rule("Fizz", n => n % 3 == 0));
engine.AddRule(new Rule("Buzz", n => n % 5 == 0));

engine.AddRule(new Rule("Bar", n => n % 7 == 0));
engine.AddRule(new Rule("Foo", n => n * 10 > 100));

engine.Run();
