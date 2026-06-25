using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();

        public void AddCard(Card card)
        {
            if (card != null)
                cards.Add(card);
        }

        public int GetValue()
        {
            int total = 0;
            int aces = 0;

            foreach (var c in cards)
            {
                if (c.value == 1)
                {
                    aces++;
                    total += 11;
                }
                else if (c.value > 10)
                {
                    total += 10;
                }
                else
                {
                    total += c.value;
                }
            }

            while (total > 21 && aces > 0)
            {
                total -= 10;
                aces--;
            }

            return total;
        }

        public bool IsBlackjack()
        {
            return cards.Count == 2 && GetValue() == 21;
        }

        public bool IsBust()
        {
            return GetValue() > 21;
        }

        public bool IsSoft()
        {
            foreach (var c in cards)
            {
                if (c.value == 1)
                    return GetValue() <= 21;
            }

            return false;
        }

        public override string ToString()
        {
            return string.Join(", ", cards);
        }
    }
}