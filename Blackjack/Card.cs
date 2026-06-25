using System;

namespace Blackjack
{
    public enum Suit
    {
        Spade,
        Heart,
        Diamond,
        Club
    }
    public class Card
    {
        public Suit suit;
        public int value; // 1–13

        public Card(Suit suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }
        
        public override string ToString()
        {
            return $"{ValueName()} of {suit}";
        }

        private string ValueName()
        {
            return value switch //check if its a face card/ace
            {
                1 => "Ace",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => value.ToString()
            };
        }

    }
}