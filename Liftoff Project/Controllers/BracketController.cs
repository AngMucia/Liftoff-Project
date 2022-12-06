using Liftoff_Project.Models;
using Liftoff_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Liftoff_Project.Controllers
{
    public class BracketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateBracket()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBracket(AddBracketViewModel addBracketViewModel) 
        {
            return View();
        }

        [HttpGet]
        public IActionResult CompareBracket()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CompareBracket(Bracket bracket)
        {
            return View();
        }
    }
}
