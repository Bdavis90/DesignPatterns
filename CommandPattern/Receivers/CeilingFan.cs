using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        private string name;
        private int speed;

        public CeilingFan(string name)
        {
            this.name = name;
            speed = OFF;
        }

        public void High()
        {
            Console.WriteLine($"{name} fan has been set to High");
            speed = HIGH;
        }

        public void Medium()
        {
            Console.WriteLine($"{name} fan has been set to Medium");
            speed = MEDIUM;
        }

        public void Low()
        {
            Console.WriteLine($"{name} fan has been set to Low");
            speed = LOW ;
        }

        public void Off()
        {
            Console.WriteLine($"{name} fan has been set to Off");
            speed = OFF;
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
