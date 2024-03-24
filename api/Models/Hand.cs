using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Hand
    {
        public int Id { get; set; }
        public State State { get; set; }
        public int RoomId { get; set; }
    }

    public enum State
    {
        Preflop,
        Flop,
        Turn,
        River,
        Show
        
    }
}

