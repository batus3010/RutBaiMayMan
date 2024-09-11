using RutBaiMayMan.Models;
using Spectre.Console;

namespace RutBaiMayMan
{
    internal class Program
	{
		static void Main(string[] args)
		{
			// test GetRandomCard
			GameManager gameManager = new GameManager();
			Player player1 = new Player();
			Player player2 = new Player();

			Game game = gameManager.SetupGame(player1, player2);

			List<Card> randomCards = game.Cards;
			foreach(var card in randomCards)
            {
                AnsiConsole.MarkupLine($"[bold]{card.Rank} of {card.Suit}[/]");
            }
			
		}

		//static void Main(string[] args)
		//{
		//	Player player = new Player();
		//	player.Username = "JohnDoe";
		//	player.TotalWins = 10;
		//	player.Status = PlayerStatus.Online;


		//	string[] cards_drawed = new string[10];
		//	string[] card_icon = { "heart", "spade", "diamond", "club" };
		//	string[] card_number = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
		//	int score = 0;
		//	int draw_count = 3;

		//	for (int i = 0; i < cards_drawed.Length; i++)
		//	{
		//		string card = Random.GetRandomCard(card_icon, card_number);
		//		if (cards_drawed.Contains(card))
		//		{
		//			i--;
		//			continue;
		//		}

		//		cards_drawed[i] = card;
		//	}

		//	// Display hidden cards
		//	var table = new Table();
		//	table.AddColumn("Cards");
		//	for (int i = 0; i < cards_drawed.Length; i++)
		//	{
		//		table.AddRow("[grey]Hidden[/]");
		//	}
		//	AnsiConsole.Write(table);

		//	while (true)
		//	{
  //              Console.WriteLine($"Current score: {score}\n");
  //              // Prompt user to select a card
  //              var user_card = AnsiConsole.Prompt(
		//			new SelectionPrompt<string>()
		//				.Title("Select a card to reveal:")
		//				.PageSize(5)
		//				.MoreChoicesText("[grey](Move up and down to navigate)[/]")
		//				.AddChoices(new[] { "1", "2", "3", "4", "5" , "6", "7", "8", "9", "10"}));

		//		int selectedIndex = int.Parse(user_card) - 1;
				
		//		// Update the table to reveal the selected card
		//		table = new Table();
		//		table.AddColumn("Cards");
		//		for (int i = 0; i < cards_drawed.Length; i++)
		//		{
		//			if (i == selectedIndex)
		//			{
		//				table.AddRow(cards_drawed[i]);
		//			}
		//			else
		//			{
		//				table.AddRow("[grey]Hidden[/]");
		//			}
		//		}

		//		score += int.Parse(cards_drawed[selectedIndex].Split(" ")[0]);
		//		draw_count -= 1;
		//		if(draw_count < 0)
		//		{
  //                  break;
  //              }

		//		AnsiConsole.Clear();
		//		AnsiConsole.Write(table);
		//	}
		//}

		//public static class Random
		//{
		//	public static string GetRandomCard(string[] card_icon, string[] card_number)
		//	{
		//		int icon_index = new System.Random().Next(0, card_icon.Length);
		//		int number_index = new System.Random().Next(0, card_number.Length);

		//		return $"{card_number[number_index]} {card_icon[icon_index].ToUpper()}";
		//	}
		//}

		
	}
}
