using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace Liftoff_Project.Models
{
    public class PlayerStats
    {
           
            [ForeignKey("PlayerId")]
            public int PlayerId { get; set; }
            public string SubIns { get; set; }
            public string Total_PlayTime_min { get; set; }
            public string AveragePlayTime_min { get; set; }
            public string FoulsCommitted { get; set; }
            public string FoulsSuffered { get; set; }
            public string OwnGoals { get; set; }
            public string OffSides { get; set; }
            public string RedCards { get; set; }
            public string YellowCards { get; set; }
            public string GoalAssists { get; set; }
            public string ShotsOnTarget { get; set; }
            public string TotalShots { get; set; }
            public string TotalGoals { get; set; }
            public string GoalsConceded { get; set; }
            public string Saves { get; set; }
            public string ShotsFaced { get; set; }
            public string UpdateTime { get; set; }
        

    }
}
