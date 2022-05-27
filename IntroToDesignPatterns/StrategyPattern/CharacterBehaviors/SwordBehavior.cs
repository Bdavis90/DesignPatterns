using StrategyPattern.StrategyPattern.CharacterInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategyPattern.CharacterBehaviors
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Sword Attack!");
        }
    }
}
