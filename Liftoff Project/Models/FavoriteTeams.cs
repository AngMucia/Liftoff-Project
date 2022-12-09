using Microsoft.AspNetCore.Identity;

namespace Liftoff_Project.Models
{
    public class FavoriteTeams
    {
        public string UserId { get; set; }
        public IdentityUser User { get; set; }  
        public string TeamId { get; set; }
        public Team Team { get; set; }
        
    }
}
