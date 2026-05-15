using System.Text.Json;
using WeatherComrade.Api.Models;

namespace WeatherComrade.Api.Services;

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public WeatherService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<WeatherResponse?> GetWeatherAsync(string city)
    {
        var apiKey = _configuration["WeatherApi:ApiKey"];

        var url =
            $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

        var response = await _httpClient.GetAsync(url);

        if (!response.IsSuccessStatusCode)
            return null;

        var json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<WeatherResponse>(
            json,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
    }
}