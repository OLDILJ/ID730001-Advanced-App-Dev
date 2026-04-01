namespace Blackjack
{

    internal class Program
    {

        /*
        * List of states
        * Menu = 0,
        Config = 1,
        DeckSelect = 2,
        HighScore = 3,
        DealerStart = 4,
        PlayerTurn = 5,
        COMTurn = 6,
        DealerTurn = 7,
        RecordHighScore = 8,
        */
        public static void Main()
        {
            StateMachine BeginStateMachine = new StateMachine();
            BeginStateMachine.InitializeStateMachine();
        }
       
    }
}