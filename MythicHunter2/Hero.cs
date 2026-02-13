using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MythicHunter2.Items;

namespace MythicHunter2
{
    public class Hero
    {
        private int power;
        private int mana;
        private int health;
        private List<Item> inventory;
        private int currentXposition;
        private int currentYposition;

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }

        public int Mana
        {
            get
            {
                return this.mana;
            }
            set
            {
                this.mana = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public int CurrentXPosition
        {
            get
            {
                return currentXposition;
            }
            set
            {
                currentXposition = value;
            }
        }

        public int CurrentYPosition
        {
            get
            {
                return currentYposition;
            }
            set
            {
                currentYposition = value;
            }
        }
    }
}
