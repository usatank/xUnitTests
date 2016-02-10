using Xunit;

namespace DemoCode.Tests
{
    public class AssertingRandes
    {
        [Fact]
        public void ShouldIncreaseHealthAfterSleep()
        {
            PlayerCharacter test = new PlayerCharacter { Health = 100 };
            test.Sleep();
            Assert.InRange(test.Health, 101, 200);

        }
    }
}
