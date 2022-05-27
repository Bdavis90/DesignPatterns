using StrategyPattern.StrategyPattern.CharacterBehaviors;
using StrategyPattern.StrategyPattern.CharacterInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategyPattern
{
    public abstract class Character
    {
        public IWeaponBehavior weaponBehavior;
        public abstract void Fight();

        public void SetWeapon(IWeaponBehavior wb)
        {
            weaponBehavior = wb;
        }
    }

    public class King : Character
    {
        public King()
        {
            weaponBehavior = new SwordBehavior();
        }

        public override void Fight()
        {
            Console.WriteLine("I'm the King and I will destroy you!");
            weaponBehavior.UseWeapon();
        }
    }

    public class Queen : Character
    {
        public Queen()
        {
            weaponBehavior = new KnifeBehavior();
        }

        public override void Fight()
        {
            Console.WriteLine("I'm the Queen and the king will destroy you!");
            weaponBehavior.UseWeapon();
        }
    }

    public class Knight : Character
    {
        public Knight()
        {
            weaponBehavior = new AxeBehavior();
        }

        public override void Fight()
        {
            Console.WriteLine("I'm a Knight and I will defend my King!");
            weaponBehavior.UseWeapon();
        }
    }

    public class Troll : Character
    {
        public Troll()
        {
            weaponBehavior = new KnifeBehavior();
        }

        public override void Fight()
        {
            Console.WriteLine("Me troll. Die humand!");
            weaponBehavior.UseWeapon();
        }
    }
}
