using System.Collections.Generic;

namespace Liftoff_Project.Models
{
    public class TeamStandingsObject
    {
        public string Status { get; set; }
        public List<TeamGroupStandings> Data { get; set; }
    }
}
