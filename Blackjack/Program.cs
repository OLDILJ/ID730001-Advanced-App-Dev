namespace Blackjack
{

    internal class Program
    {
        public bool GameLoop { get; set; }
        public Global.State GState { get; private set; }

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
            var Prog = new Program();
            Prog.GameLoop = true;
            
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Test123");
            Prog.AssignEnum();
            Console.WriteLine(Prog.GState.ToString());
            
            //while MenuStateTrue run menu code
            while (Prog.GameLoop)
            {
                switch (Prog.GState)
                {
                    case Global.State.Menu:
                        break;
                    case Global.State.Config:
                        break;
                    case Global.State.DeckSelect:
                        Console.WriteLine("Deck Select Started");
                        break;
                    case Global.State.HighScore:
                        break;
                    case Global.State.DealerStart:
                        break;
                    case Global.State.PlayerTurn:
                        break;
                    case Global.State.COMTurn:
                        break;
                    case Global.State.DealerTurn:
                        break;
                    case Global.State.RecordHighScore:
                        break;
                    default:
                        break;
                }
            }
        }
        public Global.State AssignEnum()
        {
            string Test = Console.ReadLine();
            int value;
            if (int.TryParse(Test, out value))
            {
                if (value >= 10 || value <= 0)
                {
                    Console.WriteLine("Invalid Start Condition Try Again");
                }
                Console.WriteLine($"Valid Start Condition Continuing To {value} State");
                GState = (Global.State)value;
                return GState;
            }
            else
            {
                Console.WriteLine("NAN Please Try Again");
            }
            return GState;
        }
    }
}