using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot robot;

        public EnemyRobotAdapter(EnemyRobot robot)
        {
            this.robot = robot;
        }

        public void AssignDriver(string DriverName)
        {
            robot.ReactToHuman(DriverName);
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void FireWeapon()
        {
            robot.SmashWithHands();
        }
    }
}
