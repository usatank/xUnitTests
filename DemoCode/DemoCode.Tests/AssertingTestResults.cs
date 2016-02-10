using Xunit;

namespace DemoCode.Tests
{

    public class AssertingTestResults
    {

        [Fact]
        public void ShouldJoinNames()
        {
            NameJoiner test = new NameJoiner();
            string result = test.Join("Andrii", "Yuskov");

            Assert.Equal("Andrii Yuskov", result);
        }

        [Fact]
        public void ShouldJoinNames_CaseUnsensitive()
        {
            NameJoiner test = new NameJoiner();
            string result = test.Join("ANDRII", "YUSKOV");

            Assert.Equal("Andrii Yuskov", result, ignoreCase: true);

        }

        [Fact]
        public void ShouldJoinNames_SubstringContents()
        {
            NameJoiner test = new NameJoiner();
            string actualResult = test.Join("Andrii", "Yuskov");
            string expectedResult = "Andrii";

            Assert.Contains(expectedResult, actualResult);
         
        }

        [Fact]
        public void ShouldJoinNames_StringStartsWith()
        {
            NameJoiner test = new NameJoiner();
            string actualResult = test.Join("Andrii", "Yuskov");
            string expectedResult = "Andrii";

            Assert.StartsWith(expectedResult, actualResult);

        }

        [Fact]
        public void ShouldJoinNames_StringEndsWith()
        {
            NameJoiner test = new NameJoiner();
            string actualResult = test.Join("Andrii", "Yuskov");
            string expectedResult = "ov";

            Assert.EndsWith(expectedResult, actualResult);
           
        }
    }//class
}
