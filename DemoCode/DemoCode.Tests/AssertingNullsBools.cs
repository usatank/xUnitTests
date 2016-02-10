using Xunit;

namespace DemoCode.Tests
{
    public class AssertingNullsBools
    {
        [Fact]
        public void ShouldHaveDefaultRandomGeneratedName()
        {
            PlayerCharacter test = new PlayerCharacter();
            var actualResult = test.Name;
            Assert.False(string.IsNullOrWhiteSpace(actualResult));

        }

        [Fact]
        public void ShouldHaveDeafultName2()
        {
            PlayerCharacter test = new PlayerCharacter();
            var actualResult = test.Name;

            Assert.True(!string.IsNullOrEmpty(actualResult));
        }

        [Fact]
        public void ShouldNoHaveNickName()
        {
            PlayerCharacter test = new PlayerCharacter();
            var actualResult = test.NickName;

            Assert.Null(actualResult);
        }

    }
}
