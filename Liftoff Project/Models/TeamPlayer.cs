namespace Liftoff_Project.Models
{
    public class TeamPlayer
    {
        public Player Player { get; set; }
        public int PlayerId { get; set; }
        public Team Team { get; set; }
        public string TeamId { get; set; }

        public TeamPlayer()
        {

        }
    }
}
