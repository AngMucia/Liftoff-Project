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
        private string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2Mzg5MTNlNWZhNzhmOWNkZjQxMzg2ODEiLCJpYXQiOjE2NzA4NjUyNDcsImV4cCI6MTY3MDk1MTY0N30.e1hd3hfd1Zlad0lCj_cHY5z5Vl9hjB7kmU5IQaG_doc";
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
        public IActionResult CreateBracket(string[] team1, string[] team2, string[] team3, string[] team4, string[] team5, string[] team6, string[] team7, string[] team8, string[] team9) 
        {
            Bracket myBracket = new Bracket();
            teams = GetTeams();
            List<Team> allTeams = new List<Team>();
            for (int i = 0; i < teams.Result.Count; i++)
            {
                allTeams.Add(teams.Result[i]);
            }
            ViewBag.Teams = allTeams;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"team1: {team1[i]}\nTeam2: {team2[i]}\nTeam3: {team3[i]}\nTeam4: {team4[i]}\nteam5: {team5[i]}\nteam6: {team6[i]}\nteam7: {team7[i]}");


            }
            Console.WriteLine($"TEAM8: {team8[0]} {team8[1]}\nteam9: {team9[0]}");
            myBracket.BracketTeams = new Dictionary<string, string[]>();
            myBracket.BracketTeams.Add("team1", team1);
            myBracket.BracketTeams.Add("team2", team2);
            myBracket.BracketTeams.Add("team3", team3);
            myBracket.BracketTeams.Add("team4", team4);
            myBracket.BracketTeams.Add("team5", team5);
            myBracket.BracketTeams.Add("team6", team6);
            myBracket.BracketTeams.Add("team7", team7);
            myBracket.BracketTeams.Add("team8", team8);
            myBracket.BracketTeams.Add("team9", team9);
            return View("Index");
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
