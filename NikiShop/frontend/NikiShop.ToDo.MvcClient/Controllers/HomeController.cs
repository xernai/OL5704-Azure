using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NikiShop.ToDo.MvcClient.Models;
using NikiShop.ToDo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace NikiShop.ToDo.MvcClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _client;
        private string _scriptsApiUrl = "weatherforecast/GetAllToDoList";

        public HomeController(ILogger<HomeController> logger, HttpClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await _client.GetAsync(_scriptsApiUrl);
            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            //List<Tarea> data = JsonSerializer.Deserialize<List<Tarea>>(stringData, options);
            var data = JsonSerializer.Deserialize<List<ToDoList>>(stringData, options);

            var listTareas = data;

            return View(listTareas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ToDo()
        {
            // TODO: usar la clase HttpClient de .NET para conectarse a la API
            // var baseURL = "http://localhost:44323/"
            // var baseURL = baseURL + "WeatherForecast/GetAllToDoList"
            // var httpClient = new HttpClient();

            // httpClient deserializarlo a un Modelo = todoList

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
