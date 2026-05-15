using WeatherComrade.Api.Models;

namespace WeatherComrade.Api.Services;

public class RecommendationService
{
    public CompanionState GetCompanionState(WeatherResponse weather)
    {
        var condition = weather.Weather?[0].Main?.ToLower() ?? "Clear";
        var temp = weather.Main?.Temp ?? 23;

        if (condition.Contains("rain"))
        {
            return new CompanionState
            {
                Image = "/images/rainy.png",
                Recommendation = "Bring an umbrella!"
            };
        }

        if (condition.Contains("snow"))
        {
            return new CompanionState
            {
                Image = "/images/snowy.png",
                Recommendation = "Wear a winter coat!"
            };
        }

        if (temp > 25)
        {
            return new CompanionState
            {
                Image = "/images/sunny.png",
                Recommendation = "Stay hydrated today!"
            };
        }

        return new CompanionState
        {
            Image = "/images/cloudy.png",
            Recommendation = "Nice weather today!"
        };
    }
}