using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atneevkin17
{
    internal class Character
    {
        private int health;
        private string name;
        private int minHit;
        private int maxHit;
        public int Health
        {
            get { return health; }
        }
        public int MaxHit
        {
            get { return maxHit; }
        }
        public int MinHit
        {
            get { return minHit; }
        }
        public string Name
        {
            get { return name; }
        }
        public Character(int health, string name, int minHit, int maxHit)
        {
            this.health = health;
            this.name = name;
            this.minHit = minHit;
            this.maxHit = maxHit;
        }
        public bool Isalive
        {
            get
            {
                if (health > 0)
                    return true;
                else
                    return false;
            }
        }
        public int GetAttackDamage()
        {
            Random rnd = new Random();
            return rnd.Next(minHit, maxHit);
           
        }
        public int TakeDamage(int damageGot)
        {
            health -= damageGot;
            if (health < 0)
                health = 0;
            return health;
        }
        public int Heal(int getheal)
        {
            return (health += getheal);
        }
    }
}
