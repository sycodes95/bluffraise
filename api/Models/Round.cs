using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Enums;

namespace api.Models
{
    public class Round
    {
        public int Id { get; set; }
        public State State { get; set; }
        public int Pot { get; set; }
        public int RoomId { get; set; }
        public List<CommunityCard> CommunityCards { get; set; } = new List<CommunityCard>();

        public List<PlayerHand> PlayerHands { get; set; } = new List<PlayerHand>();

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

