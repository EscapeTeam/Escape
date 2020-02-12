namespace Escape.Backend.Entities
{
    public class PlayedRoom
    {
        public Room Room { get; set; }
        public Team Team { get; set; }
        public bool Completed { get; set; }

    }
}