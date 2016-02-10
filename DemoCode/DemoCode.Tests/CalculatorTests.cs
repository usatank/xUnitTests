using Xunit;

namespace DemoCode.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAdd()
        {
            var sut = new Calculator();
            var result = sut.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void ShouldAdd2()
        {
            var sut = new Calculator();
            var result = sut.Add(-2, -2);
            Assert.Equal(-4, result);
        }

        [Fact]
        public void ShouldAddDoubles()
        {
            var sut = new Calculator();
            double result = sut.AddDoubles(2.1, 2.3);
            Assert.Equal(4.4, result, 1);
        }

        [Fact]
        public void Divide()
        {
            var sut = new Calculator();
            var result = sut.Divide(4, 2);
            Assert.Equal(2, result);
        }
    }
}
