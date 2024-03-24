using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int SmallBlind { get; set; }
        public int BigBlind { get; set; }
        public int MaxBuyIn { get; set; }
        public int MinBuyIn { get; set; }
        public string GameType { get; set; } = string.Empty;
        public List<Chat> Chats { get; set; } = new List<Chat>();
        public List<TablePlayer> RoomUsers { get; set; } = new List<TablePlayer>();

        
    }
}