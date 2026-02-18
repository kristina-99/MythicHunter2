using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter2.Items
{
    public class Potion : Item
    {
        public Potion() : base()
        {

        }

        public override void ActivateSpecialEffect(Hero hero)
        {
            hero.Mana += 7;
        }
    }
}
