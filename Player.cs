using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atneevkin17
{
        internal class Player: Character
    {
        private int recovery;
        private float specialAttackCoefficient;
        private bool specialAtackUsing;

        public Player(int health, string name, int minHit, int maxHit,
                      int recovery, float specialAttackCoefficient, bool specialAtackUsing)
            : base(health, name, minHit, maxHit) 
        {
            this.recovery = recovery;
            this.specialAttackCoefficient = specialAttackCoefficient;
            this.specialAtackUsing = specialAtackUsing;
        }
        public float SpecialAtack()
            {
                int normalDamage = GetAttackDamage();
                return normalDamage * specialAttackCoefficient;
            }
        }
}
