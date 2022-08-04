using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class StereoOffCommand : ICommand
    {
        private Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
        }
    }
}
