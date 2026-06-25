namespace Blackjack
{
    public class Dealer
    {
        public string name = "Dealer";
        public Hand hand = new Hand();

        public bool ShouldHit()
        {
            return hand.GetValue() <= 16;
        }

        public string ShowPartialHand()
        {
            var cards = hand.ToString();
            return cards;
        }

        public string ShowFullHand()
        {
            return hand.ToString();
        }

        public override string ToString()
        {
            return $"{name} | Hand: {hand}";
        }
    }
}