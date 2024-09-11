namespace RutBaiMayMan.Models
{
    internal class Game
    {
        public int GameId { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public List<Card> Cards { get; set; } // 10 cards selected by the server
        public List<Card> Player1Cards { get; set; } // 3 cards selected by player 1
        public List<Card> Player2Cards { get; set; } // 3 cards selected by player 2
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public GameResult Result { get; set; }
        public DateTime PlayedAt { get; set; }
    }

    public enum GameResult
    {
        Player1Win,
        Player2Win,
        Draw
    }
}
