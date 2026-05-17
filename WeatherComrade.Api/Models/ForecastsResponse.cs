using System.Text.Json.Serialization;

namespace WeatherComrade.Api.Models;

public class ForecastResponse
{
    [JsonPropertyName("list")]
    public List<ForecastItem>? List { get; set; }
}

public class ForecastItem
{
    [JsonPropertyName("dt_txt")]
    public string? DateText { get; set; }

    [JsonPropertyName("main")]
    public ForecastMain? Main { get; set; }

    [JsonPropertyName("weather")]
    public List<ForecastWeather>? Weather { get; set; }
}

public class ForecastMain
{
    [JsonPropertyName("temp")]
    public double Temp { get; set; }
}

public class ForecastWeather
{
    [JsonPropertyName("main")]
    public string? Main { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }
}