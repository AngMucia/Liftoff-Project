using Liftoff_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Liftoff_Project.ViewModels
{
    public class AddBracketViewModel
    {
       public List<Team> Teams { get; set; }
        public string BracketTeams { get; set; }
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        /*public List<Team> Teams { get; set; }
        public string TeamId { get; set; }*/
        public Bracket Brackets { get; set; }
        public int BracketId { get; set;}
       
        public AddBracketViewModel(IdentityUser user, Bracket brackets, List<Team> teams, string bracketTeams, string userId)
        {
            Brackets = brackets;
            User = user;
            UserId = userId;
            BracketTeams = "";
            for(int i = 0; i < teams.Count; i++)
            {
                BracketTeams += teams[i].Name_en;
                if(i < teams.Count - 1)
                {
                    BracketTeams += ", ";
                }
            }
            
        }
        public AddBracketViewModel() { }
    }
}
