using System.Collections.Generic;

namespace Escape.Backend.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public List<PlayedRoom> PlayerRooms {get; set;}
        public List<User> Users {get; set;}
    }
}