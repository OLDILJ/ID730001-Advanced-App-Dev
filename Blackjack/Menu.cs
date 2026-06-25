using System;

namespace Blackjack
{
    public class Menu
    {
        public void OpenMenu()
        {
            while (true)
            {
                Console.WriteLine("=== BLACKJACK MENU ===");
                Console.WriteLine("1. Human vs Human");
                Console.WriteLine("2. Human vs CPU");
                Console.WriteLine("3. Exit");
                Console.WriteLine();

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        StartHumanGame();
                        break;

                    case "2":
                        StartCpuGame();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        private void StartHumanGame()
        {
            Console.Write("Enter Player 1 name: ");
            string p1 = Console.ReadLine();

            Console.Write("Enter Player 2 name: ");
            string p2 = Console.ReadLine();

            var game = new BlackjackGame(GamePresets.TwoHumans(p1, p2));
            game.PlayGame();
        }

        private void StartCpuGame()
        {
            Console.Write("Enter Player name: ");
            string p1 = Console.ReadLine();
            var game = new BlackjackGame(GamePresets.HumanVsCpu(p1));
            game.PlayGame();
        }
    }
}