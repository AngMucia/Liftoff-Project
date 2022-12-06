using Microsoft.Net.Http.Headers;

namespace Liftoff_Project.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Height_meter { get; set; }
        public int Age { get; set; }
        public string Citizenship { get; set; }
        public string Team { get; set; }
        public int Jersey { get; set; }
        public string Position { get; set; }
    }
}
