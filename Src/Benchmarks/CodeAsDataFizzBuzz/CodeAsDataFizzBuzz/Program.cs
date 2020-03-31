using BenchmarkDotNet.Running;
using System;

namespace CodeAsDataFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //new TestFizzBuzzClassIf().Test();
            //new FizzBuzzClassSwitchTest().Test();
            //new FizzBuzzChainTest().Test();
            //new FizzBuzzClassCodeAsDataTest().Test();
            //new FizzBuzzClassCodeAsDataLinqTest().Test();

            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
