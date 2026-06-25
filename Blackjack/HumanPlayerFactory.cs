namespace Blackjack
{
    public class HumanPlayerFactory : PlayerFactory
    {
        public Player Create(string name)
        {
            return new Player(name, new HumanStrategy());
        }
    }
}