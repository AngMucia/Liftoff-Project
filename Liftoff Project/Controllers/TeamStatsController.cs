using Liftoff_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using Liftoff_Project.Data;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Liftoff_Project.Controllers
{
    public class TeamStatsController : Controller
    {
        private string baseUrl = "http://api.cup2022.ir/api/v1/";
        private string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2Mzg5MTNlNWZhNzhmOWNkZjQxMzg2ODEiLCJpYXQiOjE2NzA2MTE3OTYsImV4cCI6MTY3MDY5ODE5Nn0.K2Gsh-OACq5RTR3c2U_B_oKzgRnVZVrfxI2r96_C054";
        private ApplicationDbContext context;
        private readonly ILogger<HomeController> _logger;

        public TeamStatsController(ApplicationDbContext contextDb, ILogger<HomeController> logger)
        {
            context = contextDb;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewTeam(string id)
        {
            
            return View();
        }

        public async Task<IList<Team>> GetTeams()
        {
            IList<Team> temp = new List<Team>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + bearerToken);
                HttpResponseMessage getData = await client.GetAsync("team");

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;
                    //Console.WriteLine(results);
                    RootObject data = JsonConvert.DeserializeObject<RootObject>(results);
                    temp = data.Data;

                }
                else
                {

                    Console.WriteLine(getData.StatusCode);
                }
            }

            return temp;
        }
    }
}
