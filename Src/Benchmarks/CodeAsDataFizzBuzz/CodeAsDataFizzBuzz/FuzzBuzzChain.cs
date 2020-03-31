using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAsDataFizzBuzz
{
    public interface IFizzBuzzChain
    {
        string Evaluate(int value);
    }

    public class FizzBuzzChain_End : IFizzBuzzChain
    {
        public FizzBuzzChain_End() { }
        public string Evaluate(int value) => value.ToString();
    }

    public class FizzBuzzChain_Zero : IFizzBuzzChain
    {
        private readonly IFizzBuzzChain _next;
        public FizzBuzzChain_Zero(IFizzBuzzChain next) => _next = next;
        public string Evaluate(int value) => value == 0 ? value.ToString() : _next.Evaluate(value);
    }

    public class FizzBuzzChain_Three : IFizzBuzzChain
    {
        private readonly IFizzBuzzChain _next;
        public FizzBuzzChain_Three(IFizzBuzzChain next) => _next = next;
        public string Evaluate(int value) => value % 3 == 0 ? "Fizz" : _next.Evaluate(value);
    }

    public class FizzBuzzChain_Five : IFizzBuzzChain
    {
        private readonly IFizzBuzzChain _next;
        public FizzBuzzChain_Five(IFizzBuzzChain next) => _next = next;
        public string Evaluate(int value) => value % 5 == 0 ? "Buzz" : _next.Evaluate(value);
    }

    public class FizzBuzzChain_ThreeFive : IFizzBuzzChain
    {
        private readonly IFizzBuzzChain _next;
        public FizzBuzzChain_ThreeFive(IFizzBuzzChain next) => _next = next;
        public string Evaluate(int value) => value % 3 == 0 && value % 5 == 0 ? "FizzBuzz" : _next.Evaluate(value);
    }

    public class FuzzBuzzChain : IFizzBuzzChain
    {
        private readonly IFizzBuzzChain _next;
        public FuzzBuzzChain() => _next = new FizzBuzzChain_Zero(
                new FizzBuzzChain_ThreeFive(
                    new FizzBuzzChain_Three(
                        new FizzBuzzChain_Five(
                            new FizzBuzzChain_End()))));
        public string Evaluate(int value) => _next.Evaluate(value);
    }

    public class FizzBuzzChainTest
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

            var fizzBuzz = new FuzzBuzzChain();

            foreach (var test in testData)
            {
                string result = fizzBuzz.Evaluate(test.value);
                if (test.expected != result) throw new InvalidOperationException("Test failed");
            }
        }
    }
}
