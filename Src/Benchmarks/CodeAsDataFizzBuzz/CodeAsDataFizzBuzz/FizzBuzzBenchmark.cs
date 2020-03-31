using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAsDataFizzBuzz
{
    [MemoryDiagnoser]
    public class FizzBuzzBenchmark
    {
        private readonly FizzBuzzClassSwitchTest _precacheSwitch = new FizzBuzzClassSwitchTest();

        [Benchmark(Description = "IfClass")]
        public void IfTest()
        {
            var ifTest = new TestFizzBuzzClassIf();
            ifTest.Test();
        }

        [Benchmark(Description = "Switch")]
        public void SwitchTest()
        {
            var switchTest = new FizzBuzzClassSwitchTest();
            switchTest.Test();
        }

        [Benchmark(Description = "Switch - new cached")]
        public void SwitchTest_New()
        {
            _precacheSwitch.Test();
        }

        [Benchmark(Description = "Chain")]
        public void FizzBuzzStrategyTest()
        {
            var strategy = new FizzBuzzChainTest();
            strategy.Test();
        }

        [Benchmark(Description = "CodeAsDataFor")]
        public void CodeAsDataTest()
        {
            var codeAsData = new FizzBuzzClassCodeAsDataTest();
            codeAsData.Test();
        }

        [Benchmark(Description = "CodeAsDataLinq")]
        public void FizzBuzzCodeAsDataLinqTest()
        {
            var strategy = new FizzBuzzClassCodeAsDataLinqTest();
            strategy.Test();
        }
    }
}
