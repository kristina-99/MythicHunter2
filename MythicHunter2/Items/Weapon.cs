using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter2.Items
{
    public class Weapon : Item
    {
        public Weapon() : base()
        {

        }

        public override void ActivateSpecialEffect(Hero hero)
        {
            hero.Power = hero.Power + hero.Power / 5;
        }
    }
}
