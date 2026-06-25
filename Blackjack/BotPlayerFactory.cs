namespace Blackjack
{
    public class BotPlayerFactory : PlayerFactory
    {
        private DrawStrategy strategy;

        public BotPlayerFactory(DrawStrategy strategy)
        {
            this.strategy = strategy;
        }

        public Player Create(string name)
        {
            return new Player(name, strategy);
        }
    }
}