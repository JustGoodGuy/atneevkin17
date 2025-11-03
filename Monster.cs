using atneevkin17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Monster : Character
{
    public Monster(int health, string name, int minHit, int maxHit)
        : base(health, name, minHit, maxHit)
    {
    }
}
