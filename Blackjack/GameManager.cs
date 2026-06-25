using System.Collections.Generic;

namespace Blackjack
{
    public class GameManager
    {
        public Deck CurrentDeck = new Deck();

        public void ResetRound()
        {
            CurrentDeck.Reset();
            CurrentDeck.Shuffle();
        }

        public void Deal(Player player)
        {
            player.hand.AddCard(CurrentDeck.DealCard());
        }

        public void DealDealer(Dealer dealer)
        {
            dealer.hand.AddCard(CurrentDeck.DealCard());
        }
    }
}