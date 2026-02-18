using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter2.Items
{
    public class Armor : Item
    {
        public Armor() : base()
        {

        }

        public override void ActivateSpecialEffect(Hero hero)
        {
            hero.Health += 5;
        }
    }
}
