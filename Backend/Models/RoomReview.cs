namespace Escape.Backend.Models
{
    public class RoomReview
    {
        public int RoomReviewId { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
    }
}