using System;
using Xunit;

namespace DemoCode.Tests
{
    
    public class AssertingExceptions
    {
        [Fact]
        public void ShouldErrorDuringDividing()
        {
            Calculator testCalc = new Calculator();

            Assert.Throws<DivideByZeroException>(() => testCalc.Divide(100, 0));

        }
        
        [Fact]
        public void ShouldErrorDuringDividing2()
        {
            Calculator calcTest = new Calculator();
            ArgumentOutOfRangeException arg = Assert.Throws<ArgumentOutOfRangeException>(() => calcTest.Divide(201, 0));
            Assert.Equal("value", arg.ParamName);
        }

    }

}
