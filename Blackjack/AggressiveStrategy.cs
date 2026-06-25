namespace Blackjack
{
    public class AggressiveStrategy : DrawStrategy
    {
        public void Execute(Player player, GameManager game)
        {
            while (player.hand.GetValue() <= 18)
            {
                game.Deal(player);

                if (player.hand.IsBust())
                    break;
            }
        }
    }
}