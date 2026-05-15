namespace WeatherComrade.Api.Models;

public class WeatherResponse
{
    public MainInfo? Main { get; set; }
    public List<WeatherInfo>? Weather { get; set; }
    public string? Name { get; set; }
}