using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeAsDataFizzBuzz
{
    internal class FizzBuzzClassCodeAsDataLinq
    {
        private static Func<int, string>[] _evaulations = new Func<int, string>[]
        {
            x => x == 0 ? x.ToString() : null,
            x => x % 3 == 0 && x % 5 == 0 ? "FizzBuzz" : null,
            x => x % 3 == 0 ? "Fizz" : null,
            x => x % 5 == 0 ? "Buzz" : null,
            x => x.ToString(),
        };

        public FizzBuzzClassCodeAsDataLinq() { }

        public string Evaluate(int value)
        {
            return _evaulations
                .Select(x => x.Invoke(value))
                .SkipWhile(x => x == null)
                .First();
        }
    }

    internal class FizzBuzzClassCodeAsDataLinqTest
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

            var fizzBuzz = new FizzBuzzClassCodeAsDataLinq();

            foreach (var test in testData)
            {
                string result = fizzBuzz.Evaluate(test.value);
                if (test.expected != result) throw new InvalidOperationException("Test failed");
            }
        }
    }

}
