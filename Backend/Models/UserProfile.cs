using System;

namespace Escape.Backend.Models
{
    public class UserProfile
    {
         public int UserProfileId { get; set; }
         public User User{get; set;}
         public DateTime BirthDate{get; set;}
         public String Description{get; set;}

    }
}