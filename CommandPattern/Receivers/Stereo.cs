using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class Stereo
    {
        private bool isOn = false;

        public bool On()
        {
            Console.WriteLine("Stereo is turned on");
            isOn = true;
            return isOn;
        }

        public bool Off()
        {
            Console.WriteLine("Stereo is turned off");
            isOn = false;
            return isOn;
        }
    }
}
