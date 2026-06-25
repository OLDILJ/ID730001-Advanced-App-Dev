namespace Blackjack
{
    public class Player
    {
        public string name;
        public Hand hand = new Hand();
        public int score = 0;
        public bool isActive = true;

        public DrawStrategy strategy;

        public Player(string name, DrawStrategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        public void PlayTurn(GameManager game)
        {
            strategy.Execute(this, game);
        }

        public void ReceiveResult(string outcome)
        {
            if (outcome == "Blackjack")
                score += 2;
            else if (outcome == "Win")
                score += 1;
            else if (outcome == "Tie")
                score += 0;
            else if (outcome == "Loss")
                score -= 1;
            else if (outcome == "Surrender")
                score -= 1;

            if (score <= -10)
                isActive = false;
            Console.WriteLine($"{name} {outcome}");
            
        }

        public override string ToString()
        {
            return $"{name} | Score: {score} | Hand: {hand} (Total: {hand.GetValue()})";
        }
    }
}