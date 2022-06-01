using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherDisplays
{
    public class StatisticsDisplay : IObserver
    {
        WeatherData weatherData;
        // Pass in the WeatherData we want to observe
        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"Statistics: Temp: {temp}, Humidity: {humidity}, Pressure: {pressure}");

        }
        public void Update()
        {
            Console.WriteLine($"Statistics: Temp: {weatherData.GetTemperature()}, Humidity: {weatherData.GetHumidity()}, Pressure: {weatherData.GetPressure()}");

        }
    }
}
