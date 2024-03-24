using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class TablePlayer
    {
        public int Id { get; set; }

        public int Coins { get; set; }

        //relationships
        public string AppUserId { get; set; }
        public int RoomId { get; set; }

        //navigation property
        public AppUser AppUser { get; set; }

        public Table Table { get; set; }

    }
}