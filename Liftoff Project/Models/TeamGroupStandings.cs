using System.Collections.Generic;

namespace Liftoff_Project.Models
{
    public class TeamGroupStandings
    {
        public string _id { get; set; }
        public string Group { get; set; }
        public List<TeamStandings> Teams;
    }
}
