using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Enums;

namespace api.Models
{
    public class CommunityCard
    {
        public int Id { get; set; }

        public Card? Card { get; set; }

        public int HandId { get; set; }

    }
}