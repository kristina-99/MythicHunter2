using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter2
{
    public class Monster
    {
        private int power;
        private int health;

        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    health = value;
                }
            }
        }

        public Monster()
        {
            this.Power = 10;
            this.Health = 20;
        }

        public Monster(int power, int health)
        { 
            this.Power = power;
            this.Health = health;
        }
    }
}
