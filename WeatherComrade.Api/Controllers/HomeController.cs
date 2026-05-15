using Microsoft.AspNetCore.Mvc;
using WeatherComrade.Api.Models;
using WeatherComrade.Api.Services;

namespace WeatherComrade.Api.Controllers;

public class HomeController : Controller
{
    private readonly WeatherService _weatherService;
    private readonly RecommendationService _recommendationService;

    public HomeController(
        WeatherService weatherService,
        RecommendationService recommendationService)
    {
        _weatherService = weatherService;
        _recommendationService = recommendationService;
    }

    public async Task<IActionResult> Index()
    {
        var weather =
            await _weatherService.GetWeatherAsync("Winnipeg");

        var model = new HomeViewModel
        {
            WeatherData = weather
        };

        if (weather != null)
        {
            model.Companion =
                _recommendationService.GetCompanionState(weather);
        }

        return View(model);
    }
}