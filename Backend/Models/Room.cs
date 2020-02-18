using System.Collections.Generic;

namespace Escape.Backend.Models
{
    public class Room
    {
        // public Room()
        // {
        //     RoomReviews = new List<RoomReview>();
        // }
        public int RoomId { get; set; }
        public string Name { get; set; }
        public string Theme { get; set; }
        public int Difficulty { get; set; }
        public Society Society { get; set; }
        public List<RoomReview> RoomReviews {get; set;}
        
        //public List<Played> Id { get; set; }
    }
}