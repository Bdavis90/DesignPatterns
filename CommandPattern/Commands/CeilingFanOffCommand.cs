using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan ceilingFan;
        private int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
        }

        public void Undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
            {
                ceilingFan.High();
            }
            else if (prevSpeed == CeilingFan.MEDIUM)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == CeilingFan.LOW)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == CeilingFan.OFF)
            {
                ceilingFan.Off();
            }
        }
    }
}
