namespace Blackjack
{
    using System;
    using System.Windows.Input;
    public class Menu
    {
        public Menu()
        {
        }
        public void OpenMenu()
        {
            string UserInput;
            int MenuPosition = 0;
            Console.WriteLine("BlackJack Menu");
            Console.WriteLine("Type 1 To View Available Decks");
            Console.WriteLine("Type 2 To Start Game");
            Console.WriteLine("Type 3 to View Best Streaks");
            switch (_ = Console.ReadLine())
            {
                case "1":
                    //OpenDeckViewer();
                    break;
                case "2":
                    Console.WriteLine("Selected Deck: {Example Deck}");
                    Console.WriteLine("Basic Config: {Config Name}");
                    Console.WriteLine("Are You Ready To Start?");
                    Console.WriteLine("(Y)es, (N)o");
                    UserInput = Console.ReadLine();
                    UserInput = UserInput.ToUpper();
                    switch (UserInput)
                    {
                        case "Y":
                            //StartGame();
                            Console.WriteLine("You Selected YES");
                            break;
                        case "N":
                            Console.WriteLine("You Selected NO");
                            OpenMenu();
                            break;
                        default:
                            Console.WriteLine("UNKNOWN INPUT TRY AGAIN");
                            OpenMenu();
                            break;
                    }
                    break;
                case "3":
                    //ViewHighScore();
                    break;
                default:
                    {
                        Console.WriteLine("Please Enter 1, 2, or 3");
                        OpenMenu();
                        break;
                    }
            }
        }

    }

}
