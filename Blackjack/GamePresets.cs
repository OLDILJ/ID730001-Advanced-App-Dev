using System.Collections.Generic;

namespace Blackjack
{
    public static class GamePresets
    {
        public static List<(string name, PlayerFactory factory)> TwoHumans(string p1, string p2)
        {
            if (string.IsNullOrWhiteSpace(p1))
                p1 = "Player 1";

            if (string.IsNullOrWhiteSpace(p2))
                p2 = "Player 2";

            return new List<(string, PlayerFactory)>
            {
                (p1, new HumanPlayerFactory()),
                (p2, new HumanPlayerFactory())
            };
        }

        public static List<(string name, PlayerFactory factory)> HumanVsCpu(string p1)
        {
            if (string.IsNullOrWhiteSpace(p1))
                p1 = "Player";
            return new List<(string, PlayerFactory)>
            {
                (p1, new HumanPlayerFactory()),

                ("CPU1", new BotPlayerFactory(new BasicStrategy())),
                ("CPU2", new BotPlayerFactory(new ConservativeStrategy())),
                ("CPU3", new BotPlayerFactory(new AggressiveStrategy())) // I could expand this if I want to add more cpus but 3 seems fine. though I do want to come back to this and add a proper menu config setting for cpus
            };
        }
    }
}