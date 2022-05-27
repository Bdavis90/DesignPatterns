using StrategyPattern.StrategyPattern.CharacterInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategyPattern.CharacterBehaviors
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Bow Attack!");
        }
    }
}
