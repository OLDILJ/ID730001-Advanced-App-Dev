using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class StateMachine
    {
        public bool GameLoop { get; set; }
        public Global.State GState { get; private set; }

        public StateMachine() 
        {   
        }
        public void InitializeStateMachine()
        {
            Menu CurMenu = new Menu();
            GameLoop = true;

            Console.WriteLine("Hello, World!");

            Console.WriteLine("Test123");
            AssignEnum();
            Console.WriteLine(GState.ToString());

            //while MenuStateTrue run menu code
            while (GameLoop)
            {
                switch (GState)
                {
                    case Global.State.Menu:
                        CurMenu.OpenMenu();
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
                if (value >= 10 || value <= -1)
                {
                    Console.WriteLine("Invalid Start Condition Try Again");
                    InitializeStateMachine();
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
