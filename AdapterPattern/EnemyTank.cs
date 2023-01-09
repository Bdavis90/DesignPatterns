using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class EnemyTank : IEnemyAttacker
    {
        Random rng = new();
        public void AssignDriver(string DriverName)
        {
            Console.WriteLine($"{DriverName} is driving the tank");
        }

        public void DriveForward()
        {
            int movement = rng.Next(5) + 1;
            Console.WriteLine($"Enemy Tank moves {movement} spaces");
        }

        public void FireWeapon()
        {
            int attackDamage = rng.Next(10) + 1;
            Console.WriteLine($"Enemy Tank does {attackDamage} Damage");
        }
    }
}
