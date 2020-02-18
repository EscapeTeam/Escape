using System;

namespace Escape.Backend.Models
{
    public class UserTeam
    {
        public User User { get; set; }
        public Team Team { get; set; }
    }
}