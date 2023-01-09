using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class EnemyRobot
    {
        Random rng = new();

        public void SmashWithHands()
        {
            int attackDamage = rng.Next(10) + 1;
            Console.WriteLine($"Enemy Robot causes {attackDamage} Damage with its hands");
        }

        public void WalkForward()
        {
            int movement = rng.Next(5) + 1;
            Console.WriteLine($"Enemy Robot walk forward {movement} spaces");
        }

        public void ReactToHuman(string DriverName)
        {
            Console.WriteLine($"Enemy Robot Tramps on {DriverName}");
        }
    }
}
