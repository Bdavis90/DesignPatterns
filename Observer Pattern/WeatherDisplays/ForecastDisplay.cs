using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherDisplays
{
    public class ForecastDisplay : IObserver, IDisposable
    {
        WeatherData weatherData;
        // Pass in the WeatherData we want to observe
        public ForecastDisplay(WeatherData weatherData)
        {
            weatherData.OnTempChange += Update;
        }
        //Event Observer
        private void Update(object? sender, WeatherData e)
        {
            Console.WriteLine($"Forecast: Temp: {e.temp}, Humidity: {e.humidity}, Pressure: {e.pressure}");
        }
        //Push Observer
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"Forecast: Temp: {temp}, Humidity: {humidity}, Pressure: {pressure}");

        }
        //Pull Observer
        public void Update()
        {
            Console.WriteLine($"Forecast: Temp: {weatherData.GetTemperature()}, Humidity: {weatherData.GetHumidity()}, Pressure: {weatherData.GetPressure()}");

        }
        public void Dispose()
        {
            weatherData.OnTempChange -= Update;
        }
    }
}
