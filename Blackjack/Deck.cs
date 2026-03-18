using System;

namespace Blackjack
{
    internal class Deck
    {
        private int DeckSize = 52;
        private int SuitCount = 4;
        private int JokerCount = 0;
        private List<Card> CardList;
        private string DeckName;
        public Deck(int DeckSize, int SuitCount, int JokerCount, string DeckName, List<Card> CardList)
        {
            this.DeckSize = DeckSize;
            this.SuitCount = SuitCount;
            this.JokerCount = JokerCount;
            this.CardList = new List<Card>();
            this.DeckName = "Default";
        }
    }
}