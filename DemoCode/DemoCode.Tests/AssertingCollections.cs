using Xunit;
namespace DemoCode.Tests
{
    public class AssertingCollections
    {
        [Fact]
        public void ShouldHaveNoEmptyWeapons()
        {
            PlayerCharacter test = new PlayerCharacter();
            Assert.All(test.Weapons, weapon => Assert.False(string.IsNullOrWhiteSpace(weapon)));
                        
        }

        [Fact]
        public void ShouldCOntaintWeapon1()
        {
            PlayerCharacter test = new PlayerCharacter();
            Assert.Contains("Weapon1", test.Weapons);

        }

    }
}
