using Liftoff_Project.Data;
using Liftoff_Project.Models;
using Liftoff_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Liftoff_Project.Controllers
{
    public class BracketController : Controller
    {
        private ApplicationDbContext context;
        public BracketController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        
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
