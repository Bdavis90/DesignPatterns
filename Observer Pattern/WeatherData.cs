using Observer_Pattern.WeatherDisplays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
#if true
    // Bad Don't do!
    public class WeatherData
    {
        CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
        ForecastDisplay forecastDisplay = new ForecastDisplay();

        public void MeasurementsChanged()
        {
            float temp = RandomWeather.GetTemperature();
            float humidity = RandomWeather.GetHumidity();
            float pressure = RandomWeather.GetPressure();

            currentConditionsDisplay.Update(temp, humidity, pressure);
            statisticsDisplay.Update(temp, humidity, pressure);
            forecastDisplay.Update(temp, humidity, pressure);
        }



    }
#endif


}
