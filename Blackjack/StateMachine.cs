using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class StateMachine
    {
        public GameManager game = new GameManager();
        public Dealer dealer = new Dealer();
        public List<Player> players;

        public bool GameLoop = true;

        public StateMachine(List<Player> players)
        {
            this.players = players;
        }

        public void Run()
        {
            while (GameLoop)
            {
                StartRound();

                PlayerPhase();

                DealerTurn();

                ResolveRound();

                CheckGameEnd();
            }

            ShowLeaderboard();
        }

        
        void PlayerPhase()
        {
            Console.WriteLine();
            Console.WriteLine("PLAYER PHASE");
            Console.WriteLine();

            foreach (var player in players)
            {
                if (!player.isActive)
                    continue;

                Console.WriteLine($"--- {player.name}'s Turn ---");
                Console.WriteLine($"Strategy: {player.strategy.GetType().Name}");
                Console.WriteLine($"Hand: {player.hand} | Total: {player.hand.GetValue()} | Soft: {player.hand.IsSoft()}");
                player.PlayTurn(game);
                Console.WriteLine($"End of turn: {player.name}");
                Console.WriteLine($"Cards remaining after {player.name}: {game.CurrentDeck.CardsRemaining()}");
                Console.WriteLine("--------------------------------");
                Console.WriteLine();

            }
        }
        

        void StartRound()
        {
            Console.WriteLine("NEW ROUND STARTED");

            game.ResetRound();

            foreach (var p in players)
            {
                if (p.isActive)
                {
                    p.hand = new Hand();
                    game.Deal(p);
                    game.Deal(p);
                }
            }

            dealer.hand = new Hand();
            game.DealDealer(dealer);
            game.DealDealer(dealer);
            Console.WriteLine($"Dealer shows: {dealer.ShowPartialHand()}");
        }

        void DealerTurn()
        {
            Console.WriteLine("Dealer Turn");

            while (dealer.ShouldHit())
            {
                game.DealDealer(dealer);
            }
            Console.WriteLine($"Cards remaining after dealer: {game.CurrentDeck.CardsRemaining()}");
        }

        void ResolveRound()
        {
            Console.WriteLine("Dealer reveals full hand:");
            Console.WriteLine(dealer.ShowFullHand());
            int dealerValue = dealer.hand.GetValue(); 
            bool dealerBust = dealer.hand.IsBust();

            foreach (var player in players)
            {
                if (!player.isActive)
                    continue;

                int playerValue = player.hand.GetValue();
                bool blackjack = player.hand.IsBlackjack();

                if (player.hand.IsBust())
                {
                    player.ReceiveResult("Loss");
                }
                else if (dealerBust)
                {
                    player.ReceiveResult(blackjack ? "Blackjack" : "Win");
                }
                else if (blackjack)
                {
                    player.ReceiveResult("Blackjack");
                }
                else if (playerValue > dealerValue)
                {
                    player.ReceiveResult("Win");
                }
                else if (playerValue < dealerValue)
                {
                    player.ReceiveResult("Loss");
                }
                else
                {
                    player.ReceiveResult("Tie");
                }
            }
            Console.WriteLine();
            Console.WriteLine("SCOREBOARD");

            foreach (var player in players)
            {
                Console.WriteLine($"{player.name} | Score: {player.score}");
            }
            Console.WriteLine();
        }

        void CheckGameEnd()
        {
            bool anyActive = false;

            foreach (var p in players)
            {
                if (p.isActive)
                    anyActive = true;
            }

            if (!anyActive)
                GameLoop = false;

            Console.WriteLine("Continue? (y/n)");
            if (Console.ReadLine() == "n")
                GameLoop = false;
        }

        void ShowLeaderboard()
        {
            Console.WriteLine("FINAL LEADERBOARD");

            players.Sort((a, b) => b.score.CompareTo(a.score));

            foreach (var p in players)
            {
                Console.WriteLine(p);
            }
        }
    }
}