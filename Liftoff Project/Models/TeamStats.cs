using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Liftoff_Project.Models
{
    public class TeamStats
    {
        public string TeamName { get; set; }
        public string Date_US_Eastern { get; set; }
        public string Time_US_Eastern { get; set; }
        public string Fixture { get; set; }
        public string Home_Team { get; set; }
        public string Home_Goal { get; set; }
        public string Away_Goal { get; set; }
        public string Away_Team { get; set; }
        public string FoulsCommitted { get; set; }
        public string YellowCards { get; set; }
        public string RedCards { get; set; }
        public string Offsides { get; set; }
        public string WonCorners { get; set; }
        public string Saves { get; set; }
        public string PossessionPct { get; set; }
        public string TotalShots { get; set; }
        public string ShotsOnTarget { get; set; }
        public string ShotPct { get; set; }
        public string PenaltyKickGoals { get; set; }
        public string PenaltyKickShots { get; set; }
        public string AccuratePasses { get; set; }
        public string TotalPasses { get; set; }
        public string PassPct { get; set; }
        public string AccurateCrosses { get; set; }
        public string TotalCrosses { get; set; }
        public string CrossPct { get; set; }
        public string TotalLongBalls { get; set; }
        public string AccurateLongBalls { get; set; }
        public string LongballPct { get; set; }
        public string BlockedShots { get; set; }
        public string EffectiveTackles { get; set; }
            public string TotalTackles { get; set; }
            public string TacklePct { get; set; }
            public string Interceptions { get; set; }
            public string EffectiveClearance { get; set; }
            public string TotalClearance { get; set; }
            public string UpdateTime { get; set; }

        public TeamStats() { }
        public TeamStats(string value)
        {
            Home_Goal = value;
            FoulsCommitted = value;
            YellowCards = value;
            RedCards = value;
            Offsides = value;
            WonCorners = value;
            Saves = value;
            TotalShots = value;
            PenaltyKickGoals = value;
            PenaltyKickShots = value;
            TotalPasses = value;
        }

        public void SumAll(List<TeamStats> stats)
        {
            foreach(var statsItem in stats)
            {
                this.Home_Goal = "" + (int.Parse(this.Home_Goal) + int.Parse(statsItem.Home_Goal));
                this.FoulsCommitted = "" + (int.Parse(this.FoulsCommitted) + int.Parse(statsItem.FoulsCommitted));
                this.YellowCards = "" + (int.Parse(this.YellowCards) + int.Parse(statsItem.YellowCards));
                this.RedCards = "" + (int.Parse(this.RedCards) + int.Parse(statsItem.RedCards));
                this.Offsides = "" + (int.Parse(this.Offsides) + int.Parse(statsItem.Offsides));
                this.WonCorners = "" + (int.Parse(this.WonCorners) + int.Parse(statsItem.WonCorners));
                this.Saves = "" + (int.Parse(this.Saves) + int.Parse(statsItem.Saves));
                this.TotalShots = "" + (int.Parse(this.TotalShots) + int.Parse(statsItem.TotalShots));
                this.PenaltyKickGoals = "" + (int.Parse(this.PenaltyKickGoals) + int.Parse(statsItem.PenaltyKickGoals));
                this.PenaltyKickShots = "" + (int.Parse(this.PenaltyKickShots) + int.Parse(statsItem.PenaltyKickShots));
                this.TotalPasses = "" + (int.Parse(this.TotalPasses) + int.Parse(statsItem.TotalPasses));
            }
        }
    }
}
