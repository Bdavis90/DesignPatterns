using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherDisplays
{
    public class CurrentConditionsDisplay: IObserver, IDisposable
    {
        WeatherData weatherData;
        // Pass in the WeatherData we want to observe
        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            weatherData.OnTempChange += Update;
        }
        // For Events
        private void Update(object? sender, WeatherData e)
        {
            Console.WriteLine($"CurrentCondition: Temp: {e.temp}, Humidity: {e.humidity}, Pressure: {e.pressure}");
        }
        // For Pushing
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"CurrentCondition: Temp: {temp}, Humidity: {humidity}, Pressure: {pressure}");
        }
        // For Pulling
        public void Update()
        {
            Console.WriteLine($"CurrentCondition: Temp: {weatherData.GetTemperature()}, Humidity: {weatherData.GetHumidity()}, Pressure: {weatherData.GetPressure()}");
        }

        public void Dispose()
        {
            weatherData.OnTempChange -= Update;
        }
    }
}
