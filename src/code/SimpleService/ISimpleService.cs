using SimpleApi;

namespace SimpleService
{
    public interface ISimpleService
    {
        IEnumerable<WeatherForecast> GetForecast();
    }
}
