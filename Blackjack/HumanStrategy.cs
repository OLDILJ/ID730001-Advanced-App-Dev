using System;
using System.Numerics;

namespace Blackjack
{
    public class HumanStrategy : DrawStrategy
    {
        public void Execute(Player player, GameManager game)
        {
            bool playing = true;
            bool firstAction = true;

            while (playing)
            {
                Console.WriteLine();
                Console.WriteLine($"Player: {player.name}");
                Console.WriteLine($"Hand: {player.hand}");
                Console.WriteLine($"Total: {player.hand.GetValue()}");
                Console.WriteLine("Choose: hit / stand / surrender");
                Console.WriteLine();

                string input = Console.ReadLine();

                if (input == "hit")
                {
                    game.Deal(player);

                    Console.WriteLine($"Drew card. New total: {player.hand.GetValue()}");

                    if (player.hand.IsBust())
                    {
                        Console.WriteLine("BUST!");
                        playing = false;
                    }

                    firstAction = false;
                }
                else if (input == "stand")
                {
                    playing = false;
                }
                else if (input == "surrender" && firstAction)
                {
                    player.ReceiveResult("Surrender");
                    playing = false;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}