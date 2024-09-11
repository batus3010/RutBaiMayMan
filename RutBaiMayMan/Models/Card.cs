using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RutBaiMayMan.Models
{
    internal class Card
    {
        public int CardId { get; set; }
        public string Suit { get; set; } = string.Empty;
        public string Rank { get; set; } = string.Empty;
        public int Value { get; set; } = 0;
    }
}
