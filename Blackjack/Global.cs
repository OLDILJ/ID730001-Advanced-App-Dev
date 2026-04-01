using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Global
    {
        public Global()
        {

        }
        public enum State
        {
            Menu = 0,
            Config = 1,
            DeckSelect = 2,
            HighScore = 3,
            DealerStart = 4,
            PlayerTurn = 5,
            COMTurn = 6,
            DealerTurn = 7,
            RecordHighScore = 8,
            Unknown = 99
        }

    }
}
