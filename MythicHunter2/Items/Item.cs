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

        public Item()
        { 
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
        
        

        public abstract void ActivateSpecialEffect(Hero hero);
    }
}
