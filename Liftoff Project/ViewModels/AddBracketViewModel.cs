using Liftoff_Project.Models;
using System.Collections.Generic;

namespace Liftoff_Project.ViewModels
{
    public class AddBracketViewModel
    {
        public User User { get; set; }
        public string UserId { get; set; }
        /*public List<Team> Teams { get; set; }
        public string TeamId { get; set; }*/
        public Bracket Brackets { get; set; }
        public int BracketId { get; set;}

        public AddBracketViewModel(User user, List<Bracket> brackets)
        {
            
            User = user;
        }
    }
}
