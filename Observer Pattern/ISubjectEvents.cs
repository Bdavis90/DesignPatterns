namespace ObserverPattern
{
    public interface ISubjectEvents
    {
        event EventHandler<WeatherData> OnTempChange;
    }
}