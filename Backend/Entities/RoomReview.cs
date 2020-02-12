namespace Escape.Backend.Entities
{
    public class RoomReview
    {
        public int Id {get; set;}
        public User User {get; set;}
        public Room Room {get; set;}
    }
}