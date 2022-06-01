using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class RandomWeather
    {

        public static float GetTemperature()
        {
            Random r = new Random();
            return r.NextSingle() * r.Next(100);
        }

        public static float GetHumidity()
        {
            Random r = new Random();
            return r.NextSingle() * r.Next(100);
        }

        public static float GetPressure()
        {
            Random r = new Random();
            return r.NextSingle() * r.Next(100);
        }
    }
}
