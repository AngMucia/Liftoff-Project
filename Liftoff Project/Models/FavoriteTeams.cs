using Microsoft.AspNetCore.Identity;

namespace Liftoff_Project.Models
{
    public class FavoriteTeams
    {
        public string UserId { get; set; }
        public User User { get; set; }  
        public int TeamId { get; set; }
        public Team Team { get; set; }
        
    }
}
