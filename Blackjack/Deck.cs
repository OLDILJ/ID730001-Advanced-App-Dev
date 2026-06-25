using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        private Random rand = new Random();

        public Deck()
        {
            Reset();
        }

        public void Reset()
        {
            cards.Clear();

            foreach (Suit suit in System.Enum.GetValues(typeof(Suit)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    cards.Add(new Card(suit, i));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int j = rand.Next(i, cards.Count);
                (cards[i], cards[j]) = (cards[j], cards[i]);
            }
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("Deck is empty");

            var card = cards[^1];
            cards.RemoveAt(cards.Count - 1);
            return card;
        }

        public int CardsRemaining()
        {
            return cards.Count;
        }
    }
}