using Liftoff_Project.Data;
using Liftoff_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Liftoff_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext contexDb)
        {
            _logger = logger;
            context = contexDb;
        }
        private string baseUrl = "http://api.cup2022.ir/api/v1/";
        private string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2Mzg5MTNlNWZhNzhmOWNkZjQxMzg2ODEiLCJpYXQiOjE2NzEwNDc4NzcsImV4cCI6MTY3MTEzNDI3N30.ZDFK-_XvIGnxfUCXWR9cIfXEyjuhVITy2CjOPzBUCxI";

        Task<IList<Team>> teams;
        IList<Team> favTeams = new List<Team>();
        IList<FavoriteTeams> favoriteTeams;
        IdentityUser user;

        public IActionResult Index()
        {
            ViewBag.pos = "";
            Task<IList<Team>> t;
            if (User.Identity.Name != null)
            {
                user = context.Users.Single(u => u.UserName == User.Identity.Name);
                favoriteTeams = context.FavoriteTeams.Where(ft => ft.UserId == user.Id).ToList();
                ViewBag.pos = "float-left";
            }

            teams = GetTeams();

                ViewBag.user = user;
                ViewBag.fav = favoriteTeams;
                ViewData.Model = teams.Result;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchTeam(string searchItem)
        {
            ViewBag.pos = "";
            if (User.Identity.Name != null)
            {
                user = context.Users.Single(u => u.UserName == User.Identity.Name);
                favoriteTeams = context.FavoriteTeams.Where(ft => ft.UserId == user.Id).ToList();
                ViewBag.pos = "float-left";
            }

            teams = GetTeams();
            List<Team> team = new List<Team>();
                for (int i = 0; i < teams.Result.Count; i++)
                {
                    if (searchItem.Equals(teams.Result[i].Name_en))
                    {
                        team.Add(teams.Result[i]);
                        break;
                    }
                   

                }
                if(team.Count == 0)
                {
                    ViewBag.error = "This is not an option";
                }
            ViewBag.user = user;
            ViewBag.fav = favoriteTeams;
            ViewData.Model = team;
            return View("Index");
        }

        [HttpPost]
        public IActionResult AddFavorite(string selectedFav)
        {

            user = context.Users.Single(u => u.UserName == User.Identity.Name);
            favoriteTeams = context.FavoriteTeams.Where(ft => ft.UserId == user.Id).ToList();

            FavoriteTeams addTeam = new FavoriteTeams();
                addTeam.TeamId = selectedFav;
                addTeam.UserId = user.Id;

                try
                {
                    context.FavoriteTeams.Add(addTeam);
                    context.SaveChanges();
                    favoriteTeams.Add(addTeam);
                }
                catch (Exception) { }

            teams = GetTeams();
            ViewBag.pos = "float-left";
            ViewBag.user = user;
            ViewBag.fav = favoriteTeams;
            ViewData.Model = teams.Result;
            return View("Index");
        }

        [HttpPost]
        public IActionResult RemoveFavorite(string selectedFav)
        {
            user = context.Users.Single(u => u.UserName == User.Identity.Name);
            favoriteTeams = context.FavoriteTeams.Where(ft => ft.UserId == user.Id).ToList();
            teams = GetTeams();

            for(int i = 0; i < favoriteTeams.Count; i++)
            {
                if(favoriteTeams[i].TeamId == selectedFav)
                {
                    context.FavoriteTeams.Remove(favoriteTeams[i]);
                    favoriteTeams.RemoveAt(i);
                }
            }
            context.SaveChanges();

            ViewBag.pos = "float-left";
            ViewBag.user = user;
            ViewBag.fav = favoriteTeams;
            ViewData.Model = teams.Result;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
