using System;

namespace Blackjack
{
    internal class GameManager
    {
        Deck CurrentDeck;
        public List<Card> PlayerHand = [];
        public List<Card> DealerHand = [];
        public List<Card> DiscardPile = [];
        Random rand = new Random();
        public GameManager()
        {
            CurrentDeck = new Deck(52, 4, 0, "Default", []);

        }
        public void DeckShuffle()
        {
            //Get Current Cards in Player, Dealer, And Discard 
            //Add all cards from playerhand into the currentdecks card list, Then remove all cards from player hand
            //Repeat for Discard and Dealer
            for (int i = 0; i < PlayerHand.Count; i++)
            {
                //CurrentDeck.CardList.Add(PlayerHand[i]);
                //PlayerHand[i].CardList.Remove(PlayerHand[i]);
            }
            for (int i = 0; i < DealerHand.Count; i++)
            {
                //CurrentDeck.CardList.Add(DealerHand[i]);
                //DealerHand[i].CardList.Remove(DealerHand[i]);
            }
            for (int i = 0; i < DiscardPile.Count; i++)
            {
                //CurrentDeck.CardList.Add(DiscardPile[i]);
                //DiscardPile[i].CardList.Remove(DiscardPile[i]);
            }

            // Now Shuffle the deck
            // rand.Shuffle(CurrentDeck.CardList);

        }
    }
}
