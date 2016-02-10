using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DemoCode.Tests
{
    public class OutputTest
    {
        private readonly ITestOutputHelper _helper;

        public OutputTest(ITestOutputHelper helper)
        {
            this._helper = helper;

        }

        [Fact]
        public void TestCalculator()
            {
            _helper.WriteLine("Line1");
            _helper.WriteLine("Line2");
            }
    }
}
