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
using System.Web;
using Microsoft.AspNetCore.Identity;
using System.Linq;

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
            /*teams = GetTeams();*/
           
            List<Team> allTeams = context.Teams.ToList();
            /*for (int i = 0; i < teams.Result.Count; i++)
            {
                allTeams.Add(teams.Result[i]);

            }*/
            ViewBag.Teams = allTeams;
            return View();
        }
        [HttpPost]
        public IActionResult CreateBracket(string[] team1, string[] team2, string[] team3, string[] team4, string[] team5, string[] team6, string[] team7, string[] team8, string[] team9) 
        {
            List<Team> Team = context.Teams.ToList();
            ViewBag.Teams = Team;
            Bracket myBracket = new Bracket();
            IdentityUser user = context.Users.Single(u => u.UserName == User.Identity.Name);
            myBracket.UserId = user.Id;
            myBracket.BracketTeams = string.Join(',', team1) + " " + string.Join(",", team2) + " " + string.Join(",", team3) + "  " +  string.Join(",", team4) + "  " + string.Join(",", team5) + " " + string.Join(",", team6) + " " + string.Join(",", team7) + "  " + string.Join(",", team8) + "  " + string.Join(",", team9);
            /*if (!ModelState.IsValid)
            {
                return Redirect("CreateBracket"); 
            }*/
            
            
            return View("ViewBracket");
        }

        [HttpGet]
        public IActionResult CompareBracket(/*AddBracketViewModel addBracketViewModel*/)
        {
            /*if (ModelState.IsValid)
            {
                Bracket myBracket = new Bracket
                {
                    Id = addBracketViewModel.BracketId
                };
                context.Brackets.Add(myBracket);
                context.SaveChanges();

            }*/
            return View();
        }
        
        public IActionResult ViewBracket()
        {
            return View();
        }
    }
}
