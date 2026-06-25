namespace Blackjack
{
    public class BasicStrategy : DrawStrategy
    {
        public void Execute(Player player, GameManager game)
        {
            while (player.hand.GetValue() < 17)
            {
                game.Deal(player);

                if (player.hand.IsBust())
                    break;
            }
        }
    }
}