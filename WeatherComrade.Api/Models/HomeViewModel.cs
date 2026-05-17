namespace WeatherComrade.Api.Models;

public class HomeViewModel
{
    public WeatherResponse? WeatherData { get; set; }

    public CompanionState? Companion { get; set; }
    public ForecastResponse? ForecastData { get; set; }
}