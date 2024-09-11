using RutBaiMayMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RutBaiMayMan
{

    internal class GameManager
    {
        private Random _random = new Random();
        public Game SetupGame(Player player1, Player player2)
        {
            var game = new Game
            {
                Player1 = player1,
                Player2 = player2,
                Cards = GetRandomCards(),
                Player1Score = 0,
                Player2Score = 0,
                PlayedAt = DateTime.Now
            };

            return game;
        }

        public GameResult DetermineWinner(Game game, int player1Score, int player2Score)
        {
            game.Player1Score = player1Score;
            game.Player2Score = player2Score;
            if (player1Score > player2Score)
            {
                return GameResult.Player1Win;
            }
            else if (player1Score < player2Score)
            {
                return GameResult.Player2Win;
            }
            else
            {
                return GameResult.Draw;
            }
        }
        private List<Card> GetRandomCards()
        {
            string[] cardIcons = { "heart", "spade", "diamond", "club" };
            string[] cardNumbers = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            List<Card> cardsDrawn = new List<Card>();
            HashSet<string> drawnCards = new HashSet<string>(); // track already drawn cards

            while (cardsDrawn.Count < 10)
            {
                string cardIcon = cardIcons[_random.Next(cardIcons.Length)];
                string cardNumber = cardNumbers[_random.Next(cardNumbers.Length)];
                string card = $"{cardNumber} of {cardIcon}";

                // Check if the card was already drawn
                if (!drawnCards.Contains(card))
                {
                    drawnCards.Add(card);

                    // Add to the list of drawn cards
                    cardsDrawn.Add(new Card
                    {
                        Suit = cardIcon,
                        Value = GetCardValue(cardNumber),
                        Rank = cardNumber
                    });
                }
            }

            return cardsDrawn;
        }

        private int GetCardValue(string cardNumber)
        {
            // Convert card number to its corresponding value for game logic
            return cardNumber switch
            {
                "A" => 1,
                "J" => 11,
                "Q" => 12,
                "K" => 13,
                _ => int.Parse(cardNumber)
            };
        }
    }
}
