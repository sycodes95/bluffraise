using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class PlayerHand
    {
        public int MyProperty { get; set; }
        public string CardOne { get; set; } = string.Empty;
        public string CardTwo { get; set; } = string.Empty;
        public int RoomPlayerId { get; set; }

    }
}