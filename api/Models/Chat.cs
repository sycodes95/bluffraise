using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Chat
    {
        // pk
        public int Id { get; set; }
        // fields
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // relationships
        public string AppUserId { get; set; }
        public int RoomId { get; set; }

        // Navigation Props
        public Table Table { get; set; }
        public AppUser AppUser { get; set; }

    }
}