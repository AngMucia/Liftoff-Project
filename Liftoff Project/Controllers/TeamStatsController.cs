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
        private string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2Mzg5MTNlNWZhNzhmOWNkZjQxMzg2ODEiLCJpYXQiOjE2NzA4NjUyNDcsImV4cCI6MTY3MDk1MTY0N30.e1hd3hfd1Zlad0lCj_cHY5z5Vl9hjB7kmU5IQaG_doc";
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

        [HttpPost]
        public IActionResult ViewTeam(string teamId)
        {
            List<TeamStats> overAllStats = new List<TeamStats>();
            TeamStats teamStats = new TeamStats();
            Team teamToView = new Team();

            Task<IList<Team>> teams = GetTeams();

            foreach(var team in context.Teams.ToList())
            {
                if(team.Id == teamId)
                {
                    teamToView = team;
                    break;
                }
            }
            overAllStats = context.TeamStats.Where(ts => teamToView.Name_en == ts.TeamName).Distinct().ToList();

            ViewBag.stats = overAllStats;
            ViewData.Model = teamToView;
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

        public string SumAll(List<TeamStats> stats, string name)
        {
            string temp = "";
            int sum = 0;

            for(int i = 0; i < stats.Count; i++)
            {
                if(name == "TotalShots")
                {
                    sum += int.Parse(stats[i].TotalShots);
                }
            }

            temp = sum + "";
            return temp;
        }

        public List<TeamStats> noDuplicates(string teamName)
        {
            List<TeamStats> teams = context.TeamStats.Where(ts => teamName == ts.TeamName).Distinct().ToList();
            string temp;

            for(int i = 0; i < teams.Count; i++)
            {
                temp = teams[i].Date_US_Eastern;
                if (teams[i].Date_US_Eastern.Count() > 1 && teams[i].Date_US_Eastern == temp)
                {
                    Console.WriteLine(teams[i].Date_US_Eastern.Count());
                    teams.Remove(teams[i]);
                }
            }

            return teams;
        }
    }
}
