using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter2.Items
{
    public abstract class Item
    {
        private string name;
        private int positionY;
        private int positionX;

        public Item(int positionY, int PositionX)
        { 
            this.PositionY = positionY;
            this.PositionX = PositionX;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        
        public int PositionY
        {
            get 
            {
                return this.positionY;
            }
            set
            {
                this.positionY = value;
            }
        }

        public int PositionX
        {
            get
            {
                return this.positionX;
            }
            set
            { 
                this.PositionX = value;
            }
        }

        public abstract void ActivateSpecialEffect();
    }
}
