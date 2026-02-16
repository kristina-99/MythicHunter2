using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter2.Items
{
    public class Magic : Item
    {
        public Magic(int positionY, int PositionX) : base(positionY, PositionX)
        {

        }

        public override void ActivateSpecialEffect(Hero hero)
        {
            hero.Mana -= 3;
            hero.Power += 5;
        }
    }
}
