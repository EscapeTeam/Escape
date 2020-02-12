using System;
using System.Collections.Generic;
using System.Text;

namespace Escape.Backend.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime LastLogin { get; set; }
        public List<Team> Teams { get; set; }
        public List<RoomReview> Reviews {get; set;}
        public UserProfile Profile {get; set;}

    }
}
