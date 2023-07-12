using System;

public class ListMenu : Menu
{
    private new string _menu = $@"
    
    List Options
    =========================================
    Please pick one of the following topics:
    
    1. Colors
    2. Sports
    3. Seasons
    
    4. Back to Main Menu
    =========================================
    Which list topic would you like to use?:  ";

    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        while (_action != 4)
        {
            Hangman game = new Hangman();
            _action = UserChoice();
            switch (_action)
            {
                case 1:

                    _wordFileName = "colors.txt"
                    game.StartGame(_wordFileName);
                    break;
                
                case 2:

                    _wordFileName = "sports.txt"
                    game.StartGame(_wordFileName);
                    break;

                case 3:

                    _wordFileName = "seasons.txt";
                    game.StartGame(_wordFileName);
                    break;

                default:

                    Console.WriteLine($"\nSorry, the option you entered is invalid.");
                    break;
            }
        }
    }
}