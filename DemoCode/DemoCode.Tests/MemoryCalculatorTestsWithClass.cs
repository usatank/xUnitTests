using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using System.IO;

namespace DemoCode.Tests
{
    public class MemoryCalculatorTestData
    {
        public static IEnumerable<object> TestData
        {
            get
            {
                string[] csvLines = File.ReadAllLines("TestDataCSV.csv");
                var testClasses = new List<object[]>();
                foreach (var csvLine in csvLines)
                {
                    IEnumerable<int> values = csvLine.Split(',').Select(int.Parse);
                    object[] testCase = values.Cast<object>().ToArray();
                    testClasses.Add(testCase);
                }

                return testClasses;
            }
        }
    }
        
    [Trait("Category", "Test data")]
    public class MemoryCalculatorTestsWithClass
    {

        private readonly ITestOutputHelper _outputHelper;
         
        public MemoryCalculatorTestsWithClass(ITestOutputHelper helper)
        {
            _outputHelper = helper;
        }

        [Theory]
        [MemberData("TestData", MemberType = typeof(MemoryCalculatorTestData))]
        public void ShouldSubtract(int first, int second, int expected)
        {
            _outputHelper.WriteLine("ShouldSubtract started");
            MemoryCalculator calc = new MemoryCalculator();
            calc.Clear();
            calc.Subtract(first);
            calc.Subtract(second);

            Assert.Equal(expected, calc.CurrentValue);
            _outputHelper.WriteLine("ShouldSubtract finished");

        }
    }
}
