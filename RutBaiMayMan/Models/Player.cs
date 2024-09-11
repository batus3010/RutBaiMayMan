using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RutBaiMayMan.Models
{
    internal class Player
    {
        public int PlayerId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int TotalWins { get; set; } = 0;
        public int TotalMatches { get; set; } = 0;
        public PlayerStatus Status { get; set; } = PlayerStatus.Offline;

    }

    public enum PlayerStatus
    {
        Online,
        Offline,
        Playing
    }
}
