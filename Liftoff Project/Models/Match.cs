﻿namespace Liftoff_Project.Models
{
    public class Match
    {

        public class Rootobject
        {
            public int Id { get; set; }
            public string Type { get; set; }
            public string Group { get; set; }
            public string Home_Team_Id { get; set; }
            public string Away_Team_Id { get; set; }
            public int Home_Score { get; set; }
            public int Away_Score { get; set; }
            public object Home_scorers { get; set; }
            public object Away_scorers { get; set; }
            public string Persian_date { get; set; }
            public string Local_date { get; set; }
            public string Stadium_id { get; set; }
            public string Time_elapsed { get; set; }
            public string Finished { get; set; }
            public int Matchday { get; set; }
            public string Home_team_fa { get; set; }
            public string Away_team_fa { get; set; }
            public string Home_team_en { get; set; }
            public string Away_team_en { get; set; }
            public string Home_flag { get; set; }
            public string Away_flag { get; set; }
        }

    }
}
