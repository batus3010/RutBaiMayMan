using RutBaiMayMan.Models;
using Spectre.Console;

namespace RutBaiMayMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            Player player1 = new Player { Username = "Player 1" };
            Player player2 = new Player { Username = "Player 2" };

            for (int i = 0; i < 5; i++)
            {
                AnsiConsole.MarkupLine($"Round {i + 1}");
                Game game = gameManager.SetupGame(player1, player2);

                foreach (var card in game.Player1Cards)
                {
                    AnsiConsole.MarkupLine($"{player1.Username} draws {card.Rank} of {card.Suit}");
                }

                Console.WriteLine();

                foreach (var card in game.Player2Cards)
                {
                    AnsiConsole.MarkupLine($"{player2.Username} draws {card.Rank} of {card.Suit}");
                }

                Console.WriteLine();


                GameResult result = gameManager.DetermineWinner(game);

                // show total score of each player
                AnsiConsole.MarkupLine($"{player1.Username} total score: {game.Player1Score}");
                AnsiConsole.MarkupLine($"{player2.Username} total score: {game.Player2Score}");


                if (result == GameResult.Player1Win)
                {
                    AnsiConsole.MarkupLine($"Round {i + 1}: {player1.Username} wins!");
                }
                else if (result == GameResult.Player2Win)
                {
                    AnsiConsole.MarkupLine($"Round {i + 1}: {player2.Username} wins!");
                }
                else
                {
                    AnsiConsole.MarkupLine($"Round {i + 1}: Draw!");
                }
                Console.WriteLine();
            }



        }


    }
}
