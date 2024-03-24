using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Bet
    {
        public int Id { get; set; }
        
        public int HandId { get; set; }

        public int PlayerHandId { get; set; }

        public int Amount { get; set; }

        public BetType Type { get; set; }

    }

    public enum BetType
    {
        Fold,
        Check,
        Bet,
        Call,
        Raise,
        All
    }
}