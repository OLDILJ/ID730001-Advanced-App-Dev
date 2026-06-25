namespace Blackjack
{
    public class ConservativeStrategy : DrawStrategy
    {
        public void Execute(Player player, GameManager game)
        {
            while (player.hand.GetValue() < 15)
            {
                game.Deal(player);

                if (player.hand.IsBust())
                    break;
            }
        }
    }
}