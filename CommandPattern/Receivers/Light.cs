using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class Light
    {
        public bool isOn = false;
        public string name;

        public Light(string name)
        {
            this.name = name;
        }

        public bool On()
        {
            Console.WriteLine($"{name} Light is turned on");
            isOn = true;
            return isOn;
        }

        public bool Off()
        {
            Console.WriteLine($"{name} Light is turned off");
            isOn = false;
            return isOn;
        }

    }
}
