using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DemoCode.Tests
{
    public class MemoryCalculatorTestDDT
    {
        private readonly ITestOutputHelper _outputHelper;

        public MemoryCalculatorTestDDT(ITestOutputHelper helper)
        {
            _outputHelper = helper;
        }

        [Theory]
        [InlineData(2,4,-6)]
        [InlineData(-10,-5,15)]
        [InlineData(10,0,-10)]
        public void ShouldSubtractTwoNumbers(int first, int second, int expected)
        {
            var sut = new MemoryCalculator();
            sut.Subtract(first);
            sut.Subtract(second);
            
            Assert.Equal(expected, sut.CurrentValue);

        }

    }
}
