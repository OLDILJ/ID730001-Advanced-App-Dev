using System;

namespace Blackjack
{
    internal class Card
    {
        int Value; // 1 - 13
        int Suit; // Hearts, Diamonds, Clubs, Spades
        String Name;
        String SuitNames;
        public Card()
        {
            Value = 0;
            Suit = 0;
            Name = "Zero Card";
            SuitNames = "Blank Suit";

        }
    }
}