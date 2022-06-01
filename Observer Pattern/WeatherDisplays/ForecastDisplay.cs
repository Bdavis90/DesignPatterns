using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherDisplays
{
    public class ForecastDisplay : IObserver
    {
        WeatherData weatherData;
        // Pass in the WeatherData we want to observe
        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"Forecast: Temp: {temp}, Humidity: {humidity}, Pressure: {pressure}");

        }
    }
}
