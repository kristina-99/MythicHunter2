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

        public Hero()
        {
            this.Power = 10;
            this.Mana = 5;
            this.Health = 20;
            inventory = new List<Item>();
            this.CurrentXPosition = 0;
            this.currentYposition = 0;
        }

        public void addItemToInventory(Item newItem)
        {
            inventory.Add(newItem);
        }

        public void useItem()
        {
            if (inventory.Count > 0)
            {
                Random rng = new Random();
                int chosenItemIndex = rng.Next(0, inventory.Count - 1);

                inventory[chosenItemIndex].ActivateSpecialEffect();

            }
        }


        public void Move(char inputKey)
        {
            switch (inputKey)
            {
                case 'w':
                    {
                        if (currentYposition > 0)
                        {
                            currentYposition--;
                        }
                        else
                        {
                            Console.WriteLine("The hero can't leave the map. Please move to another direction!");
                        }
                        break;
                    }
                case 's':
                    {
                        if (currentYposition < 3)
                        {
                            currentYposition++;
                        }
                        else
                        {
                            Console.WriteLine("The hero can't leave the map. Please move to another direction!");
                        }
                        break;
                    }
                case 'd':
                    {
                        if (currentXposition < 5)
                        {
                            currentXposition++;
                        }
                        else
                        {
                            Console.WriteLine("The hero can't leave the map. Please move to another direction!");
                        }
                        break;
                    }
                case 'a':
                    {
                        if (currentXposition > 0)
                        {
                            currentXposition--;
                        }
                        else
                        {
                            Console.WriteLine("The hero can't leave the map. Please move to another direction!");
                        }
                        break;
                    }
            }

        }
    }
}
