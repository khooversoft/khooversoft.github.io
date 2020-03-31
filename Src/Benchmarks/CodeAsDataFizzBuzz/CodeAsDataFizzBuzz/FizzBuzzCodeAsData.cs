using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeAsDataFizzBuzz
{
    public class FizzBuzzCodeAsData
    {
        private static Func<int, string>[] _evaulations = new Func<int, string>[]
        {
            x => x == 0 ? x.ToString() : null,
            x => x % 3 == 0 && x % 5 == 0 ? "FizzBuzz" : null,
            x => x % 3 == 0 ? "Fizz" : null,
            x => x % 5 == 0 ? "Buzz" : null,
            x => x.ToString(),
        };

        public FizzBuzzCodeAsData() { }

        public string Evaluate(int value)
        {
            for (int i = 0; i < _evaulations.Length; i++)
            {
                string result = _evaulations[i](value);
                if (result != null) return result;
            }

            throw new InvalidOperationException("should not be here");
        }
    }

    public class FizzBuzzClassCodeAsDataTest
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

            var fizzBuzz = new FizzBuzzCodeAsData();

            foreach (var test in testData)
            {
                string result = fizzBuzz.Evaluate(test.value);
                if (test.expected != result) throw new InvalidOperationException("Test failed");
            }
        }
    }

}
