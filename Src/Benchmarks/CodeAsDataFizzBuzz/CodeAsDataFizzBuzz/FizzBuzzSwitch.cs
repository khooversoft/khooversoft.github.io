using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAsDataFizzBuzz
{
    internal class FizzBuzzSwitch
    {
        public FizzBuzzSwitch() { }

        public string Evaluate(int value)
        {
            return value switch
            {
                int v when v == 0 => value.ToString(),
                int v when v % 3 == 0 && v % 5 == 0 => "FizzBuzz",
                int v when v % 3 == 0 => "Fizz",
                int v when v % 5 == 0 => "Buzz",

                _ => value.ToString(),
            };
        }
    }

    internal class FizzBuzzClassSwitchTest
    {
        public void Test()
        {
            var testData = new (int value, string expected)[]
            {
                (0, "0"),
                (1, "1"),
                (3, "Fizz"),
                (4, "4"),
                (5, "Buzz"),
                (15, "FizzBuzz"),
                (16, "16"),
            };

            var fizzBuzz = new FizzBuzzSwitch();

            foreach (var test in testData)
            {
                string result = fizzBuzz.Evaluate(test.value);
                if (test.expected != result) throw new InvalidOperationException("Test failed");
            }
        }
    }

}
