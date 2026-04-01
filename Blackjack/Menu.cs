namespace Blackjack
{
    using System;
    using System.Windows.Input;
    public class Menu
    {
        public Menu()
        {
            int MenuPosition = 0;
            Console.WriteLine("BlackJack Menu");
            Console.WriteLine("Type 1 To View Available Decks");
            Console.WriteLine("Type 2 To Start Game");
            Console.WriteLine("Type 3 to View Best Streaks");
            Console.ReadLine();
            switch (_ = Console.ReadLine())
            {
                case "1":

                    break;
                case "2":
                    Console.WriteLine("Selected Deck: {Example Deck}");
                    Console.WriteLine("Basic Config: {Config Name}");
                    Console.WriteLine("Are You Ready To Start?");
                    Console.WriteLine("(Y)es, (N)o");
                    Console.ReadLine();
                    break;
                case "3":

                    break;
                default: 
                {
                    Console.WriteLine("Please Enter 1, 2, or 3");
                    //Menu();
                        break;
                }
            }
        }

    }

}
