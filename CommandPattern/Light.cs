using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Light
    {
        public bool isOn = false;
        public bool On()
        {
            Console.WriteLine("Light is turned on");
            isOn = true;
            return isOn;
        }

        public bool Off()
        {
            Console.WriteLine("Light is turned off");
            isOn = false;
            return isOn;
        }

    }
}
