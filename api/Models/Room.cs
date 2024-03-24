using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Blinds { get; set; } = string.Empty;

        public string GameType { get; set; } = string.Empty;

        public List<Chat> Chats { get; set; } = new List<Chat>();

        public List<RoomPlayer> RoomUsers { get; set; } = new List<RoomPlayer>();

 
    }
}