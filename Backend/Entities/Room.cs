using System.Collections.Generic;

namespace Escape.Backend.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Theme { get; set; }
        public int Difficulty { get; set; }
        public Society Society { get; set; }
        public List<RoomReview> RoomReviews {get; set;}
        
        //public List<Played> Id { get; set; }
    }
}