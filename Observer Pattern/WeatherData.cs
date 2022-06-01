using ObserverPattern.Interfaces;
using ObserverPattern.WeatherDisplays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //  CONCRETE SUBJECT
    #region Original Class

#if false
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

    #endregion

    #region Observer Pattern Push
#if false

    public class WeatherData : ISubject
    {
        List<IObserver> observers;
        float temp;
        float humidity;
        float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void MeasurementsChanged()
        {
            temp = RandomWeather.GetTemperature();
            humidity = RandomWeather.GetHumidity();
            pressure = RandomWeather.GetPressure();

            NotifyObserver();
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temp, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
    }
#endif
    #endregion

    #region Observer Pattern Pull
    public class WeatherData : ISubject
    {
        List<IObserver> observers;
        float temp;
        float humidity;
        float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void MeasurementsChanged()
        {
            temp = RandomWeather.GetTemperature();
            humidity = RandomWeather.GetHumidity();
            pressure = RandomWeather.GetPressure();

            NotifyObserver();
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public float GetTemperature()
        {
            return temp;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }
    }

    #endregion

}
