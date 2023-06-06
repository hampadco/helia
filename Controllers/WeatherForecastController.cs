using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace test2.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult  Get(string CId)
    {
        var client = new RestClient("https://api.test.datacite.org");
        var request = new RestRequest("/providers?consortium-id="+CId, Method.Get);
        request.AddHeader("accept", "application/vnd.api+json");

        var response = client.Execute(request);

        var content = JsonConvert.SerializeObject(response.Content);

        return Content(content, "application/json");
    }
}
