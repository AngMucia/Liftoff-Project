namespace Liftoff_Project.Models
{
    public class Match
    {

        public class Rootobject
        {
            public int id { get; set; }
            public string type { get; set; }
            public string group { get; set; }
            public string home_team_id { get; set; }
            public string away_team_id { get; set; }
            public int home_score { get; set; }
            public int away_score { get; set; }
            public object home_scorers { get; set; }
            public object away_scorers { get; set; }
            public string persian_date { get; set; }
            public string local_date { get; set; }
            public string stadium_id { get; set; }
            public string time_elapsed { get; set; }
            public string finished { get; set; }
            public int matchday { get; set; }
            public string home_team_fa { get; set; }
            public string away_team_fa { get; set; }
            public string home_team_en { get; set; }
            public string away_team_en { get; set; }
            public string home_flag { get; set; }
            public string away_flag { get; set; }
        }

    }
}
