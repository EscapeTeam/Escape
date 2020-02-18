using System;
using System.Collections.Generic;
using System.Text;

namespace Escape.Backend.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime LastLogin { get; set; }
        public List<UserTeam> UserTeams { get; set; }
        public List<RoomReview> Reviews {get; set;}
        public UserProfile Profile {get; set;}

    }
}
