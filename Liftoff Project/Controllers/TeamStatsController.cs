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
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace Liftoff_Project.Controllers
{
    public class TeamStatsController : Controller
    {
        private string baseUrl = "http://api.cup2022.ir/api/v1/";
        private string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2Mzg5MTNlNWZhNzhmOWNkZjQxMzg2ODEiLCJpYXQiOjE2NzA5NTIxNjYsImV4cCI6MTY3MTAzODU2Nn0.vsqERHIxs5Kyo-92VuQMeaqi9dLUvTAThkYcbk7WAA8";
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
            overAllStats = context.TeamStats.Where(ts => teamToView.Name_en == ts.TeamName).ToList();
            teamStats = SumAll(overAllStats);
            
            ViewBag.teamStats = teamStats;
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

        public TeamStats SumAll(List<TeamStats> stats)
        {
            TeamStats temp = new TeamStats();
            temp.Home_Goal = "0";
            temp.FoulsCommitted = "0";
            temp.YellowCards = "0";

            for(int i = 0; i < stats.Count; i++)
            {
                temp.Home_Goal = "" + (int.Parse(temp.Home_Goal) + int.Parse(stats[i].Home_Goal));
                temp.FoulsCommitted = "" + (int.Parse(temp.FoulsCommitted) + int.Parse(stats[i].FoulsCommitted));
                temp.YellowCards = "" + (int.Parse(temp.YellowCards) + int.Parse(stats[i].YellowCards));
            }

            return temp;
        }
    }
}
