using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DemoCode.Tests
{
    
    [Trait("Category", "Player Character Tests")]
    public class PlayerCharacterTests
    {
        private readonly ITestOutputHelper _testOutput;

        public PlayerCharacterTests(ITestOutputHelper helper)
        {
            _testOutput = helper; 
        }

        [Fact]
        public void ShouldIncreaseHealthAfterSleep()
        {
            _testOutput.WriteLine("Creating PlayerCharacter");
            var sut = new PlayerCharacter { Health = 100 };
            _testOutput.WriteLine("Pleayer is going to sleep");
            sut.Sleep();
            _testOutput.WriteLine("Player awoken");
            Assert.InRange(sut.Health, 101, 200);
        }
    }
}
