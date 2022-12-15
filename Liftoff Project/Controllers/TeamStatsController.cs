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
        private string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2Mzg5MTNlNWZhNzhmOWNkZjQxMzg2ODEiLCJpYXQiOjE2NzEwNDc4NzcsImV4cCI6MTY3MTEzNDI3N30.ZDFK-_XvIGnxfUCXWR9cIfXEyjuhVITy2CjOPzBUCxI";
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

        public IActionResult ViewTeam(string teamId)
        {
            List<TeamStats> overAllStats = new List<TeamStats>();
            TeamStats teamStats = new TeamStats("0");
            Team teamToView = new Team();

            Task<IList<Team>> teams = GetTeams();

            foreach(var team in teams.Result)
            {
                if(team.Id == teamId)
                {
                    teamToView = team;
                    break;
                }
            }
            overAllStats = context.TeamStats.Where(ts => teamToView.Name_en == ts.TeamName).ToList();
            teamStats.SumAll(overAllStats);
            
            ViewBag.teamStats = teamStats;
            ViewBag.stats = overAllStats;
            ViewBag.players = context.Players.Where(p => p.Team == teamToView.Name_en).ToList();
            ViewData.Model = teamToView;
            return View();
        }

        public IActionResult ViewPlayer(int playerId)
        {
            ViewBag.team = context.Teams.Single(t => t.Name_en == context.Players.Single(p => p.Id == playerId).Team);
            ViewBag.stats = context.PlayerStats.Single(ps => ps.PlayerId == playerId);
            ViewData.Model = context.Players.Single(p => p.Id == playerId);
            return View();
        }
        public IActionResult ViewTeamStandings()
        {
            Task<List<TeamGroupStandings>> teamStandings = GetStandings();

            Console.WriteLine(teamStandings.Result.Count);

            ViewData.Model = teamStandings.Result;
            return View("Index");
        }

        public async Task<IList<Team>> GetTeams()
        {
            List<Team> temp = new List<Team>();
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

        
        public async Task<List<TeamGroupStandings>> GetStandings()
        {
            List<TeamGroupStandings> temp = new List<TeamGroupStandings>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + bearerToken);
                HttpResponseMessage getData = await client.GetAsync("standings");

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;
                    //Console.WriteLine(results);
                    TeamStandingsObject data = JsonConvert.DeserializeObject<TeamStandingsObject>(results);
                    temp = data.Data;

                    Console.WriteLine(data.Status);

                }
                else
                {

                    Console.WriteLine(getData.StatusCode);
                }
            }

            return temp;
        }

        /*public TeamStats SumAll(List<TeamStats> stats)
        {
            TeamStats temp = new TeamStats("0");

            for(int i = 0; i < stats.Count; i++)
            {
                temp.Home_Goal = "" + (int.Parse(temp.Home_Goal) + int.Parse(stats[i].Home_Goal));
                temp.FoulsCommitted = "" + (int.Parse(temp.FoulsCommitted) + int.Parse(stats[i].FoulsCommitted));
                temp.YellowCards = "" + (int.Parse(temp.YellowCards) + int.Parse(stats[i].YellowCards));
            }

            return temp;
        }*/
    }
}
