using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class RandomWeather
    {

        public static float GetTemperature()
        {
            Random r = new Random();
            float a = r.NextSingle() * r.Next(100);
            Console.WriteLine($"Temp: {a}");
            return a;
        }

        public static float GetHumidity()
        {
            Random r = new Random();
            float a = r.NextSingle() * r.Next(100);
            Console.WriteLine($"Humidity: {a}");
            return a;
        }

        public static float GetPressure()
        {
            Random r = new Random();
            float a = r.NextSingle() * r.Next(100);
            Console.WriteLine($"Pressure: {a}");
            return a;
        }
    }
}
