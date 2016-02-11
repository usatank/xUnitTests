using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DemoCode.Tests
{
    public class MemoryCalculatorFixture : IDisposable
    {
        public MemoryCalculator Sut { get; private set; }

        public MemoryCalculatorFixture()
        {
            this.Sut = new MemoryCalculator();
            
        }

        public void Dispose()
        {
            this.Sut.Dispose();
        }
    }

    [Trait("Category", "Memory Calculator Test Single Instance")]
    public class MemoryCalculatorTestsSingleInstance : IClassFixture<MemoryCalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutput;
        private readonly MemoryCalculatorFixture _fixture;

        
        public MemoryCalculatorTestsSingleInstance(ITestOutputHelper testOutput, MemoryCalculatorFixture fixture)
        {
            this._testOutput = testOutput;
            this._fixture = fixture;
            this._fixture.Sut.Clear();
        }

        [Fact]
        public void ShouldAdd()
        {
            
            _fixture.Sut.Add(10);
            _fixture.Sut.Add(5);

            Assert.Equal(15, _fixture.Sut.CurrentValue);
        }

        [Fact]
        public void ShouldSubtract()
          {
            
            _fixture.Sut.Subtract(3);
            _fixture.Sut.Subtract(4);
            Assert.Equal(-7, _fixture.Sut.CurrentValue);

        }

    }
}
