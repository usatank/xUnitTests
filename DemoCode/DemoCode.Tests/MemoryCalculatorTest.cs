using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DemoCode.Tests
{
    [Trait("Category", "TestAbstractCalculator")]
    public class MemoryCalculatorTest : IDisposable
    {
        private readonly ITestOutputHelper _helper;

        private MemoryCalculator _sut;

        public MemoryCalculatorTest(ITestOutputHelper helper)
        {
            this._helper = helper;
            _helper.WriteLine("Creating memory calculator");
            _sut = new MemoryCalculator();
        }

        [Fact]
        public void ShouldAdd()
        {
            _helper.WriteLine("ShouldAdd Executing");
            _sut.Add(10);
            _sut.Add(5);

            Assert.Equal(15, _sut.CurrentValue);
        }

        [Fact]
        public void ShouldSubtract()
        {
            _helper.WriteLine("Testing Should Subtract");
            _sut.Subtract(3);
            _sut.Subtract(1);

            Assert.Equal(-4, _sut.CurrentValue);
        }

        [Fact]
        public void ShouldDivide()
        {
            _helper.WriteLine("Should Divide");
            _sut.Divide(4);

            Assert.Equal(0, _sut.CurrentValue);
        }

        public void Dispose()
        {
            _helper.WriteLine("Disposing");
            _sut.Dispose();
        }
    }
}
