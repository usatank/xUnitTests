using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoCode.Tests
{
    public class AssertingObjectType
    {
        [Fact]
        public void ShouldCreateNormalEnemy_Simple()
        {
            var test = new EnemyFactory();
            object enemy = test.Create(true);
            Assert.IsType(typeof(BossEnemy), enemy);
        }

        [Fact]
        public void ShouldCreateNormalEnemy_Cast()
        {
            var test = new EnemyFactory();
            object enemy = test.Create(false);

            NormalEnemy normalEnemy = Assert.IsType<NormalEnemy>(enemy);
            Assert.Equal(10, normalEnemy.Power);
        }
    }
}
