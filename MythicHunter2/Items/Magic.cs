using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter2.Items
{
    public class Magic : Item
    {
        public Magic() : base()
        {
            base.Name = "Magic";
        }

        public override void ActivateSpecialEffect(Hero hero)
        {
            hero.Mana -= 3;
            hero.Power += 5;
        }
    }
}
