using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAsDataFizzBuzz
{
    internal class FizzBuzzClassIf
    {
        public FizzBuzzClassIf() { }

        public string Evaluate(int value)
        {
            if (value == 0) return value.ToString();
            else if (value % 3 == 0 && value % 5 == 0) return "FizzBuzz";
            else if (value % 3 == 0) return "Fizz";
            else if (value % 5 == 0) return "Buzz";

            return value.ToString();
        }
    }

    internal class TestFizzBuzzClassIf
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

            var fizzBuzz = new FizzBuzzClassIf();

            foreach(var test in testData)
            {
                string result = fizzBuzz.Evaluate(test.value);
                if (test.expected != result) throw new InvalidOperationException("Test failed");
            }
        }
    }
}
