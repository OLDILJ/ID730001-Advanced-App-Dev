namespace Blackjack
{
    public interface PlayerFactory
    {
        Player Create(string name);
    }
}