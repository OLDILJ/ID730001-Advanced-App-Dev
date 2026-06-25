namespace Blackjack
{
    public interface DrawStrategy
    {
        void Execute(Player player, GameManager game);
    }
}