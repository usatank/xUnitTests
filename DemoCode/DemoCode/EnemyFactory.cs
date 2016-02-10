using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class EnemyFactory
    {
        public object Create(bool isBoss)
        {
            if (isBoss)
            {
                return new BossEnemy();
            }

            return new NormalEnemy();
        }
    }
}
