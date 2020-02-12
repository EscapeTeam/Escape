using System;

namespace Escape.Backend.Entities
{
    public class UserProfile
    {
         public int Id { get; set; }
         public User User{get; set;}
         public DateTime BirthDate{get; set;}
         public String Description{get; set;}

    }
}