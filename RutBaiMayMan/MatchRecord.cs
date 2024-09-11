


using RutBaiMayMan.Models;

namespace RutBaiMayMan
{
    internal class MatchRecord
    {
        public Player player1 { get; }
        public Player player2 { get; }
        public DateTime time { get; }
        public string winner { get; } = string.Empty;

        public string score { get; } = string.Empty;

        public string GetMatchRecord()
        {
            return $"Match between {player1.Username} and {player2.Username} at {time} - Winner: {winner}";
        }
    }
}
