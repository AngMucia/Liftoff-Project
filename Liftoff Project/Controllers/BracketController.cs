using Liftoff_Project.Data;
using Liftoff_Project.Models;
using Liftoff_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;

namespace Liftoff_Project.Controllers
{
    public class BracketController : Controller
    {
        private ApplicationDbContext context;
        public BracketController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        private string baseUrl = "http://api.cup2022.ir/api/v1/";
        private string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2Mzg5MTNlNWZhNzhmOWNkZjQxMzg2ODEiLCJpYXQiOjE2NzA2MTE3OTYsImV4cCI6MTY3MDY5ODE5Nn0.K2Gsh-OACq5RTR3c2U_B_oKzgRnVZVrfxI2r96_C054";
        Task<IList<Team>> teams;
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

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateBracket()
        {
            teams = GetTeams();
            List<Team> allTeams = new List<Team>();
            for (int i = 0; i < teams.Result.Count; i++)
            {
                allTeams.Add(teams.Result[i]);

            }
            ViewBag.Teams = allTeams;
            return View();
        }
        [HttpPost]
        public IActionResult CreateBracket(AddBracketViewModel addBracketViewModel) 
        {
            teams = GetTeams();
            List<Team> allTeams = new List<Team>();
            for (int i = 0; i < teams.Result.Count; i++)
            {
                allTeams.Add(teams.Result[i]);

            }
            ViewBag.Teams = allTeams;
            return View();
        }

        [HttpGet]
        public IActionResult CompareBracket()
        {
            teams = GetTeams();
            List<Team> allTeams = new List<Team>();
            for (int i = 0; i < teams.Result.Count; i++)
            {
                allTeams.Add(teams.Result[i]);
                
            }
            ViewBag.Teams = allTeams;
            return View();
        }
        [HttpPost]
        public IActionResult CompareBracket(Bracket bracket)
        {
            return View();
        }
    }
}
