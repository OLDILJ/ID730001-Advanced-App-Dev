using System.Collections.Generic;

namespace Blackjack
{
    public class BlackjackGame
    {
        private StateMachine stateMachine;

        public BlackjackGame(List<(string name, PlayerFactory factory)> playerData)
        {
            var players = new List<Player>();

            foreach (var p in playerData)
            {
                players.Add(p.factory.Create(p.name));
            }

            stateMachine = new StateMachine(players);
        }

        public void PlayGame()
        {
            stateMachine.Run();
        }
    }
}