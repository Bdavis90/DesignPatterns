namespace ObserverPattern.Interfaces
{
    public interface ISubjectEvents
    {
        event EventHandler<WeatherData> OnTempChange;
    }
}