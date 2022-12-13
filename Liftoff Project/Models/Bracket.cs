using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Liftoff_Project.Models
{
    public class Bracket
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public string BracketTeams { get; set; }
    }
}
