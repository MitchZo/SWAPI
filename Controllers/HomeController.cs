using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SWAPI.Models;

namespace SWAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetPersonById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co");
            var response = await client.GetAsync($"api/people/{id}");
            var returnedPerson = await response.Content.ReadAsAsync<SWPerson.Person>();
            return View("PersonResults", returnedPerson);
        }
        [HttpPost]
        public async Task<IActionResult> GetPlanetById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co");
            var response = await client.GetAsync($"api/planets/{id}");
            var returnedPlanet = await response.Content.ReadAsAsync<SWPlanet.Planet>();
            return View("PlanetResults", returnedPlanet);
        }
    }
}
