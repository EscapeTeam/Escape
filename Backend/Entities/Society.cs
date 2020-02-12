using System.Collections.Generic;

namespace Escape.Backend.Entities
{
    public class Society
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public string Address {get; set;}
        public string Telephone {get; set;}
        public string Email {get; set;}
        public List<Room> Rooms {get; set;}
        public string PasswordHash {get; set;}
        public bool Enabled {get; set;}
    }
}