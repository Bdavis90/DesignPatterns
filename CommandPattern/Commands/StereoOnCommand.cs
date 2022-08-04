using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class StereoOnCommand : ICommand
    {
        private Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
