namespace Liftoff_Project.Models
{
    public class TeamStandings
    {

            public string Team_Id { get; set; }
            public string Mp { get; set; } //matches played
            public string W { get; set; } // win
            public string L { get; set; } // losses
            public string Pts { get; set; } //points
            public string Gf { get; set; } // goals for
            public string Ga { get; set; } // goals against
            public string Gd { get; set; } // goals difference
            public string D { get; set; } //draws
            public string Name_fa { get; set; } //names in some language
            public string Name_en { get; set; } //names in english
            public string Flag { get; set; } //flag
        

    }
}
