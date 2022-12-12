using Liftoff_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Liftoff_Project.ViewModels
{
    public class AddBracketViewModel
    {
       //public List<Team> Teams { get; set; }
        public List<SelectListItem> Teams { get; set; }
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        /*public List<Team> Teams { get; set; }
        public string TeamId { get; set; }*/
        public Bracket Brackets { get; set; }
        public int BracketId { get; set;}

        public AddBracketViewModel(IdentityUser user, Bracket brackets, List<Team> teams)
        {
            Teams = new List<SelectListItem>();
            foreach (var team in teams)
            {
                Teams.Add(new SelectListItem
                {
                    Value = team.Id,
                    Text = team.Name_en
                });
            }
            
            
            User = user;
        }
    }
}
