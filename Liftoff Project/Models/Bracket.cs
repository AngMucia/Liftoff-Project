using System.Collections.Generic;

namespace Liftoff_Project.Models
{
    public class Bracket
    {
        public List<Team> Teams { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }  
        public int UserId { get; set; }
    }
}
