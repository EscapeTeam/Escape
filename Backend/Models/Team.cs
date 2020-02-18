using System.Collections.Generic;

namespace Escape.Backend.Models
{
    public class Team
    {
        // public Team()
        // {
        //     PlayedRooms = new List<PlayedRoom>();
        //     Users = new List<User>();
        // }

        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<PlayedRoom> PlayedRooms { get; set; }
        public List<UserTeam> UserTeams { get; set; }
    }
}